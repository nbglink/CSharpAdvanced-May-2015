using System;

namespace S1BiggerNumber
{
    class BiggerNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter your numbers in separete lines: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);

            Console.WriteLine("Your max is: {0}", max);
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }


    }
}
