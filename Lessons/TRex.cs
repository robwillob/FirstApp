using System;
namespace Lessons

{
    public class TRex : Dinasaur
    {
        public override void EatFood()
        {
            Console.WriteLine("TRex eats");
        }

        public override void Move()
        {
            Console.WriteLine("TRex runs");
        }

        public override void Sleeps()
        {
            Console.WriteLine("Quiet! TRex is sleeping");
        }

        public override void Fights()
        {
            Console.WriteLine("TRex fights");
        }

        public override void SkinType()
        {
            Console.WriteLine("Feathery");
        }

        public override void Teeth()
        {
            Console.WriteLine("Razor sharp");
        }
    }
}