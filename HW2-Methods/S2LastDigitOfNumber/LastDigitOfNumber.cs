using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2LastDigitOfNumber
{
    class LastDigitOfNumber
    {
        static void Main()
        {
            Console.WriteLine(GetDigitAsWord(512));
            Console.WriteLine(GetDigitAsWord(1024));
            Console.WriteLine(GetDigitAsWord(12309));
        }

        static string GetDigitAsWord(int p)
        {
            string convertToString = p.ToString();

            string lastChar = convertToString.Substring(convertToString.Length - 1, 1);

            return GetCharAsWord(lastChar);
        }

        private static string GetCharAsWord(string lastChar)
        {
            switch (lastChar)
            {
                case "1":
                    return "One";
                    break;
                case "2":
                    return "Two";
                    break;
                case "3":
                    return "Three";
                    break;
                case "4":
                    return "Four";
                    break;
                case "5":
                    return "Five";
                    break;
                case "6":
                    return "Six";
                    break;
                case "7":
                    return "Seven";
                    break;
                case "8":
                    return "Eight";
                    break;
                case "9":
                    return "Nine";
                    break;
                default:
                    return "Bad input";
            }
        }

    }
}
