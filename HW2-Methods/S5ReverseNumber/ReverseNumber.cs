using System;
using System.Globalization;
using System.Threading;


namespace S5ReverseNumber
{
    class ReverseNumber
    {
       

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double input = double.Parse(Console.ReadLine());

            var reversed = GetReversedNumber(input);

            Console.WriteLine(reversed);
        }

        static string GetReversedNumber(double p)
        {
            String convertToString  = String.Concat(p); // Convert to string.

            char[] toCharArray = convertToString.ToCharArray(); // Convert to char array.

            Array.Reverse(toCharArray); // Reverse char array.

            return new string(toCharArray); // Return new reversed string.
        }
    }
}
