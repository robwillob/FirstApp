using System;
namespace Classwork
{
    public class RanchStyle : House
    {
        public RanchStyle(string foundation, string window, string roof, string doorPaint)
        : base(foundation, window, roof, doorPaint)
        {
            Console.WriteLine("Ranch Style Constructor");
        }
        public RanchStyle(string foundation, string window)
        : base(foundation, window)
        {
            Console.WriteLine("Ranch Style Constructor");
        }
    }
}