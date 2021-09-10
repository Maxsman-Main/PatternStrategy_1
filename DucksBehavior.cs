using System;

namespace DuckBehavior
{

    public interface IFly
    {
        public void Fly();
    }

    public interface IQuack
    {
        public void Quack();
    }

    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }

    public class FlyNoWay : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    public class FlyRocketPowered : IFly
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }

    public class ClassicQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class MuteQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }

    public class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}