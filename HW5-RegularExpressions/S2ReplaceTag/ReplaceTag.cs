using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace S2ReplaceTag
{
    class ReplaceTag
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"<a\s+href=([^>]+)>([^<]+)</a>";
            Regex regex = new Regex(pattern);
            string replacement = "[URL href=$1]$2[/URL]";
            string result = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(result);
        }
    }
}
