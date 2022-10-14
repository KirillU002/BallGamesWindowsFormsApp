using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomMoveBall : RandomSizeAndPointBall
    {
        public RandomMoveBall(Form form) : base(form)
        {
            vx = random.Next(-20, 20);
            vy = random.Next(-20, 20);
        }
    }
}
