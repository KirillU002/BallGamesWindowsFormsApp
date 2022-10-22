using Balls.Common;
using System;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public class SalutBall : RandomMoveBall
    {
        private float g = 0.2f;
        public SalutBall(Form form, float centerX, float centerY) : base(form)
        {
            radius = 15;
            this.centerX = centerX;
            this.centerY = centerY;

            vy = -Math.Abs(vy);
        }

        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
