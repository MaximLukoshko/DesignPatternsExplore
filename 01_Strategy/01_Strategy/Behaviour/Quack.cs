using static System.Console;

namespace _01_Strategy.Behaviour
{
    public interface IQuackable
    {
        void Quack();
    }

    public class QuackBehaviour : IQuackable
    {
        public void Quack() => WriteLine("Quack!");
    }

    public class SilentBehaviour : IQuackable
    {
        public void Quack() => WriteLine("I can't quack!");
    }

    public class SqueeBehaviour : IQuackable
    {
        public void Quack() => WriteLine("Squee!");
    }
}
