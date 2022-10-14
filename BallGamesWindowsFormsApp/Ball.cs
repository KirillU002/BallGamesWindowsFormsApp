using System;
using System.Drawing;

namespace BallGamesWindowsFormsApp
{
    public class Ball
    {        
        protected int x = 150;
        protected int y = 150;
        protected int vx = 1;
        protected int vy = 1;
        protected int size = 70;
        private MainForm form;
        protected static Random random = new Random();
        public Ball(MainForm form)
        {
            this.form = form;
        }

        public void Show()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public bool OnForm()
        {
            return x >= 0 && y >= 0 && x + size <= form.ClientSize.Width && y + size <= form.ClientSize.Height;
        }

        private void Go()
        {
            x += vx;
            y += vy;
        }

        public void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = new SolidBrush(form.BackColor);
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
