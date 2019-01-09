using System;
namespace Classwork
{
    public class Computer
    {
        // The following are fields
        string _ramMemory;
        string _hardDrive;
        string _videoResolution;
        string _operatingSystem;

        //Standard long way of a Property
        public string ramMemory
        {
            get
            {
                return _ramMemory;
            }
            set
            {
                this._ramMemory = value;
            }
        }

        public string hardDrive
        {
            get
            {
                return _hardDrive;
            }
            set
            {
                this._hardDrive = value;
            }
        }

        // Shorthand property + field/ Auto Property
        public string videoResolution { get; set; }

        public string operatingSystem { get; set; }


        public Computer() { }

        public Computer(string ramMemory, string hardDrive)
        {
            this._ramMemory = ramMemory;
            this._hardDrive = hardDrive;
            this.videoResolution = "460";
            this.operatingSystem = "Windows";
        }

        public Computer(string ramMemory, string hardDrive, string videoResolution, string operatingSystem)
        {
            this._ramMemory = ramMemory;
            this._hardDrive = hardDrive;
            this.videoResolution = videoResolution;
            this.operatingSystem = operatingSystem;
        }


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