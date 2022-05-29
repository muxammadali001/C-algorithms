using System;
using System.Linq;

namespace Algorithms
{ 
   class Validate
   {
       static Boolean IsUppercase(string s)
       {
              if (s.All(char.IsUpper))
              {
                  return true;
              }
              else
              {
                  return false;
              }
       }
       static void Main(string[] args)
       {
           Console.WriteLine("Hello World!");
       }
   }
}