using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BilliardBallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private Timer timer = new Timer();
        List<BilliardBall> balls = new List<BilliardBall>();
        int ballsCount = 20;

        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowVerticalCenterLine();

            var leftOfCenterBlueCount = balls.Where(x => x.LeftOfCenter() && x.GetBrush() != Brushes.Red).Count();
            var rightOfCenterBlueCount = balls.Where(x => x.RightOfCenter() && x.GetBrush() != Brushes.Red).Count();

            var leftOfCenterRedCount = balls.Where(x => x.LeftOfCenter() && x.GetBrush() == Brushes.Red).Count();
            var rightOfCenterRedCount = balls.Where(x => x.RightOfCenter() && x.GetBrush() == Brushes.Red).Count();

            if (leftOfCenterRedCount == leftOfCenterBlueCount && rightOfCenterRedCount == rightOfCenterBlueCount &&
                leftOfCenterRedCount + leftOfCenterBlueCount +  rightOfCenterRedCount + rightOfCenterBlueCount == ballsCount)
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ballsCount / 2; i++)
            {
                var ball = new BilliardBall(this, Brushes.Blue);
                ball.OnHited += Ball_OnHited_1;
                ball.Start();
                balls.Add(ball);

                ball = new BilliardBall(this, Brushes.Red);
                ball.OnHited += Ball_OnHited_2;
                ball.Start();
                balls.Add(ball);
            }
        }

        private void ShowVerticalCenterLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
        }

        private void Ball_OnHited_1(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel.Text = (Convert.ToInt32(leftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel.Text = (Convert.ToInt32(rightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel.Text = (Convert.ToInt32(topLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel.Text = (Convert.ToInt32(downLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void Ball_OnHited_2(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    leftLabel_2.Text = (Convert.ToInt32(leftLabel_2.Text) + 1).ToString();
                    break;
                case Side.Right:
                    rightLabel_2.Text = (Convert.ToInt32(rightLabel_2.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel_2.Text = (Convert.ToInt32(topLabel_2.Text) + 1).ToString();
                    break;
                case Side.Down:
                    downLabel_2.Text = (Convert.ToInt32(downLabel_2.Text) + 1).ToString();
                    break;
            }
        }
    }
}
