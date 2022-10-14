using System;
using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomPointBall : MoveBall
    {
        public RandomPointBall(Form form) : base(form)
        {
            x = random.Next(0, form.ClientSize.Width);
            y = random.Next(0, form.ClientSize.Height);
        }
    }
}
