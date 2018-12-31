using System;
namespace Classwork
{
    public class Computer
    {
        // The following are fields
        string _ramMemory;
        string _hardDrive;
       // string _videoResolution;
       // string _operatingSystem;

       //Standard long way of a Property
        public string ramMemory {
            get {
                return _ramMemory;
            }
            set {
                this._ramMemory = value;
            }
        }

        public string hardDrive {
            get {
                return _hardDrive;
            }
            set {
                this._hardDrive = value;
            }
        }

        // Shorthand property + field/ Auto Property
        public string VideoResolution {get; set;}

        public string operatingSystem {get; set;}

       
        // The following are Methods
        public void TurnOn()
        {
            Console.WriteLine("Computer is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Computer is off");
        }

        public void Sleep()
        {
             Console.WriteLine("I'm sleepy");
        }

    }

}