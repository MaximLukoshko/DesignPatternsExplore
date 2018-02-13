using _01_Strategy.Behaviour;
using static System.Console;

namespace _01_Strategy.Ducks
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            FlyBehaviour = new NoFlyBehaviour();
            QuackBehaviour = new SilentBehaviour();
        }

        public override void Display() => WriteLine("I'm WoodenDuck!");
    }
}
