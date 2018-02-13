using static System.Console;

namespace _01_Strategy.Behaviour
{
    public interface ISwimable
    {
        void Swim();
    }

    public class SwimBehaviour : ISwimable
    {
        public void Swim() => WriteLine("I swim!");
    }

    public class NoSwimBehaviour : ISwimable
    {
        public void Swim() => WriteLine("I can't swim!");
    }
}
