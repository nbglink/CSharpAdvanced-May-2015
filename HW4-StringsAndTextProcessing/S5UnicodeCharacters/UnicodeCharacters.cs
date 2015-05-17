using System;


namespace S5UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string unicode = String.Empty;
            foreach (char i in input)
            {
                unicode += "\\u" + ((int)i).ToString("X4");

            }
            Console.WriteLine(unicode);

            
        }
    }
    
}
