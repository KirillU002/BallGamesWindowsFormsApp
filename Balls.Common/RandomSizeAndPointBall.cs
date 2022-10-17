using System.Windows.Forms;

namespace Balls.Common
{
    public class RandomSizeAndPointBall : RandomMoveBall
    {
        public RandomSizeAndPointBall(Form form) : base(form)
        {
            radius = random.Next(5, 75);
        }
    }
}
