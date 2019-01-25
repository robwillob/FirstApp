using System;
namespace Lessons
{
    public class IndexerExample
    {
        private int[] numbers = new int[5] { 100, 200, 300, 400, 500 };

        public int Length
        {
            get { return numbers.Length; }
        }

        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }
    }
}