using DuckBehavior;
using System;

namespace Ducks
{

    public abstract class Duck
    {
        protected IFly flyBehavior;
        protected IQuack quackBehavior;

        public Duck()
        {

        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Swim");
        }

        public void SetFlyBehavior(IFly fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuack qb)
        {
            quackBehavior = qb;
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new ClassicQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard duck");
        }
    }

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new ClassicQuack();
        }
        
        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}