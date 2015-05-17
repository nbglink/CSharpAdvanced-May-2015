using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            int myStringLength = input.Length;

            if (input.Length <= myStringLength)
            {
                var newString = input.PadRight(20, Convert.ToChar("*"));
               
                Console.WriteLine(newString);
            }
        }
    }
}
