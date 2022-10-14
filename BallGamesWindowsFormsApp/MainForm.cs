using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<RandomMoveBall> moveBalls = new List<RandomMoveBall>();
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
                var moveBall = new RandomMoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        //private void MainForm_MouseDown(object sender, MouseEventArgs e)
        //{
        //    var pointBall = new PointBall(this, e.X, e.Y);
        //    pointBall.Show();
        //}

        private void stopButton_Click(object sender, EventArgs e)
        {
            clearButton.Enabled = true;
            stopButton.Enabled = false;

            var countBalls = 0;
            foreach (var ball in moveBalls)
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
            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }

            clearButton.Enabled = false;
            createButton.Enabled = true;
        }
    }
}
