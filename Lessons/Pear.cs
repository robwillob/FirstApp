using System;
namespace Lessons
{

    // Filename Pear
    public partial class Pear
    {
        public Pear(string message)
        {
            Console.WriteLine(message);
            Peel();
        }

        partial void Peel();
    }
}