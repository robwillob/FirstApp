using System;
namespace Classwork
{
    public class House
    {
        //the following are fields
        string _foundation;
        // string _roof;
        string _window;
        //string _door;

        // Standard long way of a Property
        public string Foundation
        {
            get
            {
                return _foundation;
            }
            set
            {
                this._foundation = value;
            }
        }

        public string Window
        {
            get
            {
                return _window;
            }
            set
            {
                this._window = value;
            }
        }


        //Short hand property + field;
        public string Roof { get; set; }

        public string PaintDoor { get; set; }


        public House() { }

        public House(string foundation, string window)
        : this(foundation, window, "shingles", "Green")
        { }


        public House(string foundation, string window, string roof, string doorPaint)
        {
            this._foundation = foundation;
            this._window = window;
            this.Roof = roof;
            this.PaintDoor = doorPaint;
        }



        // the following are methods
        public void OpenDoor()
        {
            Console.WriteLine("The door opens");
        }

        public void OpenDoor(bool isExterior)
        {
            if (isExterior)
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
}