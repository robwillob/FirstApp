using System;
namespace Lessons
{
    public class Triceratops : Dinasaur
    {
        public override void EatFood()
        {
            Console.WriteLine("Triceratops eats");
        }

        public override void SkinType()
        {
            Console.WriteLine("Leathery");
        }

        public override void Sleeps()
        {
            Console.WriteLine("Triceratop is sleeping");
        }

        public override void Teeth()
        {
            Console.WriteLine("Flat");
        }
    }
}