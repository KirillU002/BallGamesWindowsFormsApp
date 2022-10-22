using Balls.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalutWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private static Random random = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < random.Next(4, 11); i++)
            {
                var salut = new SalutBall(this, e.X, e.Y);
                salut.Start();
            }

        }

        private void salutButton_Click(object sender, EventArgs e)
        {
            var salut = new StartSalutBall(this);
            salut.TopReached += Salut_TopReached;
            salut.Start();
        }

        private void Salut_TopReached(object sender, TopReachedEventArgs e)
        {
            for (int i = 0; i < random.Next(4, 11); i++)
            {
                var salut = new SalutBall(this, e.X, e.Y);
                salut.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
