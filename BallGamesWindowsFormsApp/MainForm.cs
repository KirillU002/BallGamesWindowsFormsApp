using Balls.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Ball> balls = new List<Ball>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            clearButton.Enabled = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;            
            createButton.Enabled = false;

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();

                var randomSizeAndPointBall = new RandomSizeAndPointBall(this);
                balls.Add(randomSizeAndPointBall);
                randomSizeAndPointBall.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            clearButton.Enabled = true;
            stopButton.Enabled = false;

            var countBalls = 0;
            foreach (var ball in balls)
            {
                ball.Stop();

                if (ball.OnForm())
                {
                    countBalls++;
                }
            }
            MessageBox.Show($"Вы остановили {countBalls} шаров");
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Clear();
            }
            
            clearButton.Enabled = false;
            createButton.Enabled = true;
        }
    }
}
