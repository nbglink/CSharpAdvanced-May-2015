using System;


namespace S1ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            string result =  new string(arr);

            Console.WriteLine(result);
        }
    }
}
