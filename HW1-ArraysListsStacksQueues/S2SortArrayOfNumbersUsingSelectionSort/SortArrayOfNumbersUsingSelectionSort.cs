using System;
using System.Linq;

namespace S2SortArrayOfNumbersUsingSelectionSort
{
    class SortArrayOfNumbersUsingSelectionSort
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int min = numbers[i];
                int swapPos = -1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < min)
                    {
                        min = numbers[j];
                        swapPos = j;
                    }
                }

                if (swapPos > -1)
                {
                    int tmp = numbers[i];
                    numbers[i] = numbers[swapPos];
                    numbers[swapPos] = tmp;
                }
            }
           
            for (int k = 0; k < numbers.Length; k++)
            {
                Console.WriteLine(numbers[k]);
            }

        }
    }
}
