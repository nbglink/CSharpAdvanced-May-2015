using System;

namespace S3LargerThanNeighbours
{
    public class LargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }
        public static bool IsLargerThanNeighbours(int[] numbers, int i)
        {

            bool isGreater;
            if (i == 0)
            {
                isGreater = numbers[i] > numbers[i + 1]; // if it hasn't left neighbor.
            }
            else if (i == numbers.Length - 1)
            {
                isGreater = numbers[i] > numbers[i - 1]; // if it hasn't right neighbor.
            }
            else
            {
                isGreater = numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]; // if it has neighbors.
            }
            return isGreater;
        }
    }
}


