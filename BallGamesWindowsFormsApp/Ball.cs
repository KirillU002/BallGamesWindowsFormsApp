using System.Drawing;

namespace BallGamesWindowsFormsApp
{
    public class Ball
    {
        protected int x = 150;
        protected int y = 150;
        protected int size = 70;
        private MainForm form;
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

        private void Go()
        {
            x += 10;
            y += 15;
        }

        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
