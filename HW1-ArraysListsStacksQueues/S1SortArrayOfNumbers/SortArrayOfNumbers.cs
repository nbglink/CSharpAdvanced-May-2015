using System;
using System.Linq;

namespace S1SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            Array.Sort(numbers);
            
            foreach (var n in numbers)
            {
                Console.Write("{0} ",n);
            }

            



        }
    }
}
