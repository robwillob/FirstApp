using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class Hats
    {

        public delegate void TryHat(string type);  //second delegate type has no return

        public string HatType { get; }
        public int HatSize { get; }

        public Hats()    //constructor takes no parameters
        {
            TryHat myHat = TryOnHat;  //we are assigning method to the delegate
            TryALargerHat("Fadora", 7, myHat);  //method
        }

        public Hats(int size)     // constructor that takes one parameters 3rd example
        {
            this.HatSize = size;
        }



        public Hats(string type, int size)
        {
            this.HatSize = size;
            this.HatType = type;
        }

        public void TryOnHat(string message)   //method with no return type
        {
            Console.WriteLine( message);
        }

        public void TryALargerHat(string type, int oldSize, TryHat another) //this is a pointer to the TryHat method
        {
            another("I tried on a " + type + " hat at size " + (oldSize + 1).ToString());
        }

        public void FindLuckyHat(string message)      //method
        {
            Console.WriteLine("Lucky hat is {0}", message);
        }
        public void FindUglyHat(string message)
        {
            Console.WriteLine("Ugly hat is {0}", message);

        }
    }
}
