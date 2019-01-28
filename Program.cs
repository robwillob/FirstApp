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
            //FruitSample();
            // ParamsSample();
            // ModifierExamples();
            // Lesson12();
            // AbstractDemo();
            // DeconstructSample();
            // FinalizerSample();
            // IndexerSample();
            // PartialSample();
            // AnotherHouseExample();
            // GenericSample();
            CollectionSample();

        }

        static void CollectionSample()
        {
            CollectionExamples ce = new CollectionExamples();
            ce.MyArrayListExample();
            ce.myListExample();
        }

        static void GenericSample()
        {
            GenericList<int> myList = new GenericList<int>();
            myList.Add(10);

            GenericList<string> mySecondList = new GenericList<string>();
            mySecondList.Add("Happy");

            GenericList<TRex> myTRexList = new GenericList<TRex>();
            myTRexList.Add(new TRex());
        }

        static void AnotherHouseExample()
        {
            House myHouse = new House()
            {
                Roof = "Shingles",
                Window = "Double Pane",
                PaintDoor = "Red",
                Foundation = "Concrete"
            };

            Console.WriteLine("My windows choice is {0}", myHouse.Window);
        }


        static void PartialSample()
        {
            Pear pear = new Pear("Yellow");
        }



        static void IndexerSample()

        {
            IndexerExample indexExample = new IndexerExample();

            indexExample[2] = 250;

            for (int i = 0; i < indexExample.Length; i++)
            {
                Console.WriteLine("Value {0} = {1}", i, indexExample[i]);

            }
        }

        static void FinalizerSample()
        {
            FinalizerExample finalExample = new FinalizerExample("John", "Doe");

        }



        static void DeconstructSample()
        {
            string first = "Tom", last = "Jones";

            Lesson13 lesson13 = new Lesson13("John", "Doe");

            Console.WriteLine("First Name = {0} and last Name = {1}", first, last);

            lesson13.Deconstruct(out first, out last);

            Console.WriteLine("First Name = {0} and last Name = {1}", first, last);
        }

        static void AbstractDemo()
        {
            TRex trex = new TRex();
            Triceratops triceratops = new Triceratops();

            trex.EatFood();
            trex.Move();
            trex.Fights();
            trex.Sleeps();
            trex.SkinType();
            trex.Teeth();


            triceratops.EatFood();
            triceratops.Move();
            triceratops.Sleeps();
            triceratops.SkinType();
            triceratops.Teeth();


        }

        static void Lesson12()
        {
            double temp = Utilities.CelsiusToFahrenheit("43.2");
            double temp2 = Utilities.FahrenheitToCelsius("109.76");
            Console.WriteLine(temp);
            Console.WriteLine(temp2);
        }

        static void ModifierExamples()
        {
            int test = 14;
            Lesson11 myLesson = new Lesson11();
            myLesson.RefSample(ref test);
            Console.WriteLine(test);

            string first, second;
            myLesson.OutSample("John Doe  Mania", out first, out second);

            Console.Write(first);
            Console.Write(second);
        }

        static void ParamsSample()
        {
            Lesson11 lesson = new Lesson11();
            lesson.UseParams(10, 3, 24, 36, 45, 120);

            lesson.UseParams(); // passing 0

            int[] intArray = { 2, 3, 4, 5, 6 };
            lesson.UseParams(intArray);

            lesson.UseParams2(1, "Happy", false, 34.5F);

            lesson.OptionalParam(" Robin ");
            lesson.OptionalParam("Matthew", 19);
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


