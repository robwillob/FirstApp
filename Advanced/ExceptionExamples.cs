using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public class ExceptionExamples
    {
        string _exampleNull = null;

            public void MyException()
        {
            try
            {
                Console.WriteLine(_exampleNull);
            }
            catch (NullReferenceException ex)
            {

                Console.WriteLine("Null exception thrown" + ex.Message);
            }
        }

        public void MyArrayException()
        {
           // string[] names = { "Matt", "Dave", "Robin" };
           // string[] values = { "24", "42", "38" };
           string[] values = { "243333", "42444444", "38543" };

            try
            //{ byte b = byte.Parse(names[2]);
                { byte b = byte.Parse(values[2]);

                    Console.WriteLine(b);
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please provide at least 1 argument!");

            }
            catch(FormatException e)
            {
                Console.WriteLine("That is not a number");
            }
            catch(OverflowException a)
            {
                Console.WriteLine("You have given me more than a byte");
            }
        }

    }
}
