using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace S3CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
       
            string text = Console.ReadLine();
            string subString = Console.ReadLine();
 
            int count = text.Select((c, i) => text.Substring(i)).Count(x => x.StartsWith(subString, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(count);
        

        }
    }
}
