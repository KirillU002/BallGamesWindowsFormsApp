﻿namespace BallGamesWindowsFormsApp
{
    public class RandomSizeAndPointBall : RandomPointBall
    {
        public RandomSizeAndPointBall(MainForm form) : base(form)
        {
            size = random.Next(5, 120);
        }
    }
}
