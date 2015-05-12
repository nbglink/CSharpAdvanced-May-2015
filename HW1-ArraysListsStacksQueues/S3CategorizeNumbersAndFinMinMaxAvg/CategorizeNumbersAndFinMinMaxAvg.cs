using System;
using System.Collections.Generic;
using System.Linq;

namespace S3CategorizeNumbersAndFinMinMaxAvg
{
    class CategorizeNumbersAndFinMinMaxAvg
    {
        static void Main()
        {
            string input = Console.ReadLine();

            double[] numbers = input.Split(' ').Select(double.Parse).ToArray();

            List<double> roundedNumbers = new List<double>();
            List<double> floatingNumbers = new List<double>();



            for (int i = 0; i < numbers.Length; i++)
            {
               
                if (numbers[i] % 1 != 0)
                {
                    roundedNumbers.Add(numbers[i]);
                }
                else
                {
                    floatingNumbers.Add(numbers[i]);
                }

            }
            Console.WriteLine( );
            Console.Write("Floating point numbers ---> ");
            roundedNumbers.ForEach(a => Console.Write(a + " "));
            Console.WriteLine("\nmin -- {0}", floatingNumbers.Min());
            Console.WriteLine("max -- {0}", floatingNumbers.Max());
            Console.WriteLine("sum -- {0}", floatingNumbers.Sum());
            Console.WriteLine("average -- {0:f2}", floatingNumbers.Average());
            Console.WriteLine( );
            Console.Write("Rounded Numbers --->  ");
            floatingNumbers.ForEach(b => Console.Write(b + " "));
            Console.WriteLine("\nmin -- {0}", roundedNumbers.Min());
            Console.WriteLine("max -- {0}", roundedNumbers.Max());
            Console.WriteLine("sum -- {0}", roundedNumbers.Sum());
            Console.WriteLine("average -- {0:f2}", roundedNumbers.Average());

            
        }
    }
}
