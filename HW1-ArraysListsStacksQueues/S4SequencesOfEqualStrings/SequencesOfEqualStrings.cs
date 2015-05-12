using System;

namespace S4SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length - 1; i++)
            {
                Console.Write(input[i] + " ");
                if (!input[i].Equals(input[i + 1]))
                {
                    Console.WriteLine();
                }
            }
            Console.Write(input[input.Length - 1]);
            Console.WriteLine();
        }
    }
}
