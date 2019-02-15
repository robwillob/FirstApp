using System;
namespace Quiz
{
    public class Television
    {
        public string _price;
        public string _numofports;
        public string _size = "65 inch";
        public string _Mountable 

           }

        public string Price { get; set; } 

        public string IsMountable { get; set; }

        public Television() { }

        public Television(string price, string numofports)
        : this(price, numofports, " is $2000.00", "4 ports")
        { }


        public Television(string price, string numofports, string size, string mountable)
        {
            this._size = size;
            this._numofports = numofports;
            this.IsMountable = mountable;
            this.Price = price;
        }

        // the following are methods
         public void TurnOn()
        {
            Console.WriteLine("TV is turned on");
        }

        public void TurnOn(bool IsOn)
        {
            if (isOn)
            {
                Console.WriteLine("Open Front Door.");
            }
            else
            {
                Console.WriteLine("Open Bedroom door.");
            }
        }

        public void CloseDoor()
        {
            Console.WriteLine("The door closes");
        }




}



