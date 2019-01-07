using System;
namespace Lessons
{
    public class BottlesofBeer
    {
        public string BottlesOfBeerSong()
        {
            int beerNum = 99;
            string word = "bottles", result = "";

            while (beerNum > 0)
            {
                if (beerNum == 1)
                {
                    word = "bottle";
                }
                Console.WriteLine(beerNum +" "+ word + "of beer on the wall");
                Console.WriteLine(beerNum +" "+ word + "of beer");
                Console.WriteLine("Take one down");
                Console.WriteLine("Pass it around");

                beerNum--;
                if (beerNum > 0)
                {
                    Console.WriteLine(beerNum +" "+ word + "of beer on the wall");
                }
                else
                {
                    result = "No more bottles of beer on the wall";
                }


            }
            return result;
        }
    }
}