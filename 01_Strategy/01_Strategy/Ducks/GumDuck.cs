using _01_Strategy.Behaviour;
using static System.Console;

namespace _01_Strategy.Ducks
{
    public class GumDuck : Duck
    {
        public GumDuck()
        {
            FlyBehaviour = new NoFlyBehaviour();
            QuackBehaviour = new SqueeBehaviour();
        }

        public override void Display() => WriteLine("I'm GumDuck!");
    }
}
