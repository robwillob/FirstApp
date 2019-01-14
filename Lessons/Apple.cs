using System;
namespace Lessons
{
    // Apple extends Fruit
    public class Apple : Fruit
    {
        public override void EatFruit()
        {
            Console.WriteLine("I eat apples");
        }
    }
}