﻿using System.Drawing;
using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomMoveBall : RandomPointBall
    {        
        public RandomMoveBall(Form form) : base(form)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }

        private int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            var sign = 1;
            if(randomDouble < 0.5)
            {
                sign = -1;
            }
            return random.Next(2, 15) * sign;
        }
    }
}
