using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesWindowsFormsApp
{
    public class RandomMoveBall : MoveBall
    {
        public RandomMoveBall(MainForm form) : base(form)
        {
            vx = random.Next(-20, 20);
            vy = random.Next(-20, 20);
        }
    }
}
