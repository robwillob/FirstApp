using System;
namespace Lessons
{
    // Filename Pear2
    public partial class Pear
    {
        public Pear(string message, string something)
        {
            Console.WriteLine(message + " is " + something);
            Peel();
        }

        partial void Peel()
        {
            Console.WriteLine(" I peeled a pear");
        }

    }
}