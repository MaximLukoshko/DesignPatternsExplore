using _01_Strategy.Behaviour;
using static System.Console;

namespace _01_Strategy.Ducks
{
    public class SteelDuck : Duck
    {
        public SteelDuck()
        {
            FlyBehaviour = new NoFlyBehaviour();
            QuackBehaviour = new SilentBehaviour();
            SwimBehaviour = new NoSwimBehaviour();
        }

        public override void Display() => WriteLine("I'm SteelDuck!");
    }
}
