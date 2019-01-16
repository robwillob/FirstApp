using System;

namespace Lessons
{
    public class Lesson11
    {
        public const int MY_VALUE = 25;

        /* Method to demonstrate a constant which cannot chande it's value */

        public void SampleLesson11()
        {
            const string today = "Wednesday";
            // MY_VALUE = 35; // Can not change the value
            // Can use it with other variables
            int total = MY_VALUE * 2;
            Console.WriteLine(total);

            // Cannot change value at the method level constant
            // today = "Friday";
        }

        public void UseParams(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void UseParams2(params object[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }

        public void OptionalParam(string name, int age = 45)
        {
            Console.WriteLine(name + " is " + age + " years old.");
        }

        public void RefSample(ref int value)
        {
            value = value + 5;
            Console.WriteLine(value);
        }

        public void OutSample(string name, out string firstName, out string lastName)
        {
            int myIndex = name.LastIndexOf(' ');
            firstName = name.Substring(0, myIndex);
            lastName = name.Substring(myIndex + 1);
        }
    }
}