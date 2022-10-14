﻿using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            size = random.Next(5, 120);
        }
    }
}
