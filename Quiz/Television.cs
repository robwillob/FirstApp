using System;
namespace Quiz
{
    public class Television
    {
        public string price;
        public string numofports;


        public string Size { get; set; } = "65 inch";

        public bool IsMountable { get; set; }

        public void TurnOn()
        {
            Console.WriteLine("The TV is on");
        }

    }



}



