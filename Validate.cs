using System;
using System.Linq;

namespace Algorithms
{ 
   class Validate
   {
       static Boolean IsUppercase(string s)
       {
              return s.All(char.IsUpper);
       }
       static Boolean IsLowercase(string s)
       {
              return s.All(char.IsLower);
       }
       static Boolean isPassword(string s)
       {
              return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
       }
       static void Main(string[] args)
       {
           Console.WriteLine(IsUppercase("hello!"));
           Console.WriteLine(IsUppercase("Hello "));
           Console.WriteLine(IsLowercase("Hello World!"));
           Console.WriteLine(IsLowercase("hello!"));
           Console.WriteLine(isPasswordComplex("HelloWorld1"));
       }

        private static bool isPasswordComplex(string v)
        {
            throw new NotImplementedException();
        }
    }
}