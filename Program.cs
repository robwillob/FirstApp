using System;
using Lessons;
/*This namespace represents the file folder that the class is in. */

namespace Classwork
//think of this as a box or container; the container is Classwork
{
    //Class is a blueprint of an object.
    class Program
    {
        /*static is only one, means no copies; void is a return type-if we don't need to
         return any data back use void; Main is a method name(actions, functions, methods) and string etc is an array and a parameter
         Console is a class, WriteLine is a method with a parameter*/
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           // MyHouseResults();
           // MyComputerResults();
            MyNumericExamples();

        }    


        static void MyNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();
            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
        }

        static void MyHouseResults()
        {
            // Created an object instance of House called myHouse
            House myHouse = new House();
            // This sets the value of Red to the object
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor(); // the door closes
            // This gets the value of Red from the object
            Console.WriteLine(myHouse.PaintDoor); // red
            // This is a second object instance of House.
            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "green";
            Console.WriteLine(mySecondHouse.PaintDoor); // green
            Console.WriteLine(myHouse.PaintDoor); //red

        }

        static void MyComputerResults()
        {
            Computer myComputer = new Computer();
            myComputer.operatingSystem = "Off";
            myComputer.TurnOff();

            Console.WriteLine(myComputer.operatingSystem);
        }
        }

 
      
    }


