using static System.Console;

namespace _01_Strategy.Behaviour
{
    public interface IFlyable
    {
        void Fly();
    }

    public class FlyBehaviour : IFlyable
    {
        public void Fly() => WriteLine("Fly!");
    }

    public class NoFlyBehaviour : IFlyable
    {
        public void Fly() => WriteLine("I can't fly!");
    }

    public class RocketFlyBehaviour : IFlyable
    {
        public void Fly() => WriteLine("I fly by rocket!");
    }
}
