using Balls.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CathMe2WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<RandomMoveBall> moveBalls = new List<RandomMoveBall>();
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
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clearButton.Enabled = false;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveBalls != null)
            {
                foreach (var ball in moveBalls)
                {
                    if (ball.IsMovable() && ball.Contains(e.X, e.Y))
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
            foreach (var ball in moveBalls)
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
