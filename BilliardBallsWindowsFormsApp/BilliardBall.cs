using Balls.Common;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BilliardBallsWindowsFormsApp
{
    public class BilliardBall : RandomMoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;
        //public BilliardBall(Form form) : base(form)
        //{
        //    radius = 15;
        //    centerX = random.Next(MiddleSide_1(), RightSide());
        //    centerY = random.Next(TopSide(), DownSide());
        //}

        public BilliardBall(Form form, Brush brush) : base(form)
        {
            radius = 15;
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
            this.brush = brush;
        }

        public bool LeftOfCenter()
        {
            return centerX + radius < form.ClientSize.Width / 2;
        }

        public bool RightOfCenter()
        {
            return centerX - radius > form.ClientSize.Width / 2;
        }

        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }

            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerY <= TopSide() )
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }

            if (centerY >= DownSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}
