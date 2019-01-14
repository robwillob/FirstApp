using System;

namespace Quiz
{
    public class QuizClass1
    {
        public string MyGrade(string grade)
        {
            switch (grade)
            {
                case "E":
                    Console.WriteLine("E for Excellent");
                    return "Not a valid grade";
                case "V":
                    Console.WriteLine("V for Very Good");
                    return "Not a valid grade";
                case "G":
                    Console.WriteLine("G for Good");
                    return "Not a valid grade";
                case "A":
                    Console.WriteLine("A for Average");
                    return "Not a valid grade";
                case "F":
                    Console.WriteLine("F for Fail");
                    return "Not a valid grade";
                default:
                    return "Not a valid grade";
            }
        }




        public void NumDivBy()
        {
            int x = 0;
            do
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine(x);
                }

                x++;
            } while (x <= 50);
        }

    }
}