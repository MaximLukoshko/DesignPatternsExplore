using _01_Strategy.Behaviour;
using static System.Console;

namespace _01_Strategy.Ducks
{
    public class RocketDuck : Duck
    {
        public RocketDuck()
        {
            FlyBehaviour = new RocketFlyBehaviour();
            QuackBehaviour = new SilentBehaviour();
        }

        public override void Display() => WriteLine("I'm RocketDuck!");
    }
}
