using System;
namespace ArrayApp
{
    class Onedarray
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green", "black" };
            for(int i=0; i<colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            //foreach
            foreach(string i in colors)
            {
                Console.WriteLine(i);
            }

            int[] numbers = { 1, 6, 7, 9 };
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
        }

    }
}


