using System;
using Lessons;
using Quiz;
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
            // MyNumericExamples();
            // MyStringExamples();
            // StatementSamples();
            // HouseSample();
            // StrutSample();
            // ComputerSample();
            // QuizExample();
            FruitSample();
        }
        static void FruitSample()
        {
            Apple myApple = new Apple();
            myApple.EatFruit();

            Fruit myFruit = new Fruit();
            Orange myOrange = new Orange();
            myOrange.EatFruit();


            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "Composite", "Blue");
            ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);

        }

        static void QuizExample()
        {
            QuizClass1 Q1P1 = new QuizClass1();
            // Q1P1.MyGrade("E");
            Q1P1.NumDivBy();
        }









        static void ComputerSample()
        {
            Computer myComputer = new Computer("8gb", "4T");
            Console.WriteLine(myComputer.operatingSystem);
            Console.WriteLine(myComputer.ramMemory);

        }

        static void StrutSample()
        {
            BookSample bookSample = new BookSample(4.99m, "Zombie Fallout", "Mark Tufo");

            Console.WriteLine("The book " + bookSample.title + " by " + bookSample.author + " is $" + bookSample.price);
        }

        static void HouseSample()
        {
            House myHouse = new House("concrete", "triple pane");

            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(myHouse.Foundation);

            myHouse.OpenDoor(true);


        }

        static void StatementSamples()
        {
            StatementExamples se = new StatementExamples();
            // se.SampleIf();
            //se.SampleIfElse();
            //se.SampleIfChain();
            //se.SampleIfAnd();
            //se.SampleIfOr();
            //se.SampleConditional();
            //se.SampleSwitch(10);
            //se.SampleWhile();
            //se.SampleDoWhile();
            //se.SampleFor();
            //se.SampleForEach();
            // string myString = se.JumpStatementExample("Sunday");
            // Console.WriteLine(myString);
            //BottlesSong();

            se.SampleDays(DaysOfWeek.Wed);

        }

        static void BottlesSong()
        {
            BottlesofBeer beer = new BottlesofBeer();
            string song = beer.BottlesOfBeerSong();
            Console.WriteLine(song);
        }

        static void MyStringExamples()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.AddString();
            string words = myTypes.StringBuilderExample("Hello", "C Sharp", "Class");

            Console.WriteLine(words);
            myTypes.CharTypeExample();
            myTypes.EscapeExample();
            myTypes.PlaceholderExample();
            myTypes.ArrayExample();
            myTypes.MyHouseArray();
            myTypes.MultiArraySample();

        }


        static void MyNumericExamples()
        {
            NumericTypes myTypes = new NumericTypes();
            myTypes.GetSomeType();
            int something = myTypes.ConvertFloatToInt(35.9F);
            Console.WriteLine(something);

            Console.WriteLine(myTypes.LongFromInt(5600));
            myTypes.BasicMath();

            myTypes.CheckOperators();

            myTypes.IncrementDecrement();

            myTypes.SpecialValues();

            myTypes.ComparisonOperators();

            myTypes.OtherOperators();


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


