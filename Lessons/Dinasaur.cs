using System;

namespace Lessons

{
    public abstract class Dinasaur : IPrehistoric
    {
        public string Travel { get; set; } = "Walk";

        public abstract void EatFood();

        public abstract void Sleeps();

        public virtual void Move()
        {
            Console.WriteLine("the Dinosaur Moves");
        }

        public virtual void Fights()
        {
            Console.WriteLine("the Dinasour Fights");
        }

        public abstract void SkinType();
        public abstract void Teeth();
    }
}