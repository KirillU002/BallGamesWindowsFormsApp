using Balls.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CathMe2WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Ball> balls = new List<Ball>();
        private int countBalls = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            clearButton.Enabled = true;

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new RandomMoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();
                
                var randomSizeAndPointBall = new RandomSizeAndPointBall(this);
                balls.Add(randomSizeAndPointBall);
                randomSizeAndPointBall.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (balls != null)
            {
                foreach (var ball in balls)
                {
                    if (ball.IsMovable() && ball.Exists(e.X, e.Y))
                    {
                        ball.Stop();
                        countBalls++;
                    }
                }

                countBallsLabel.Text = countBalls.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Clear();
            }

            clearButton.Enabled = false;
            startButton.Enabled = true;

            countBalls = 0;
            countBallsLabel.Text = "0";
        }
    }
}
