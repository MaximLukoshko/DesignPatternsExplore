using _01_Strategy.Behaviour;
using System;

namespace _01_Strategy.Ducks
{
    public abstract class Duck
    {
        public void PerformSwim() => SwimBehaviour?.Swim();
        public void PerformQuack() => QuackBehaviour?.Quack();
        public void PerformFly() => FlyBehaviour?.Fly();
        public abstract void Display();

        public IQuackable QuackBehaviour { get; set; } = new QuackBehaviour();
        public IFlyable FlyBehaviour { get; set; } = new FlyBehaviour();
        public ISwimable SwimBehaviour { get; set; } = new SwimBehaviour();
    }
}
