﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class Ball
    {
        protected int centerX = 150;
        protected int centerY = 150;

        protected int vx = 10;
        protected int vy = 10;

        protected int radius = 25;
        protected Form form;
        private Timer timer;
        protected static Random random = new Random();
        protected Brush brush = Brushes.Aqua;

        public Ball(Form form)
        {
            this.form = form;

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        public Ball(Form form, Brush brush)
        {
            this.form = form;
            this.brush = brush;

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        public Brush GetBrush()
        {
            return brush;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public bool IsMovable()
        {
            return timer.Enabled;
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void Show()
        {
            Draw(brush);
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        }

        public int LeftSide()
        {
            return radius;
        }

        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }

        public int TopSide()
        {
            return radius;
        }

        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }

        public bool OnForm()
        {
            return centerX >= LeftSide() && centerY >= TopSide() && centerX <= RightSide() && centerY <= DownSide();
        }

        public bool Exists(int pointX, int pointY)
        {
            var dx = pointX - centerX;
            var dy = pointY - centerY;
            return dx * dx + dy * dy <= radius * radius;
        }

        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }

        public void Clear()
        {
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
        }

        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
