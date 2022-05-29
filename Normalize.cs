using System;
using System.Linq;

namespace Algorithm
{
    class Normalize
    {
        static string NormalizeString(String input)
        {
           return input.ToLower().Trim().Replace(", ", "");
        }
    }

        static void Main(string[] args)
        {
            Console.WriteLine(NormalizeString("Hello World!"));
        }
    }
}