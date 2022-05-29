using System;
using System.Collections.Generic;
using System.Linq;



class Program
 {
//     static int findMaximum(int a, int b, int c)
//     {
//         if(a > b )
//         {
//             if (a > c || a == c)
//             {
//                 return a;
//             }
//         }
//         if(b > a)
//         {
//             if (b > c || b == c)
//             {
//                 return b;
//             }
//         }
//         return c;
//     }

//     static int findMaximum2(int a, int b, int c)
//     {
//         int max = a;
//         if (b > max)
//         {
//             max = b;
//         }
//         if (c > max)
//         {
//             max = c;
//         }
//         return max;
//     }
//     static void Main(string[] args)
//     {
//         Console.WriteLine(findMaximum2(1, 2, 3));
//         Console.WriteLine(findMaximum2(8, 8, 1));
//         Console.WriteLine(findMaximum2(3, 2, 3));
//         Console.WriteLine(findMaximum2(1, 1, 9));
//         Console.WriteLine(findMaximum2(1, 9, 9));
//     }
//     static Boolean IsUppercase(string s)
//        {
//               return s.All(char.IsUpper);
//        }
//        static Boolean IsLowercase(string s)
//        {
//               return s.All(char.IsLower);
//        }
//        static Boolean isPassword(string s)
//        {
//               return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
//        }
//        static void Main(string[] args)
//        {
//            Console.WriteLine(IsUppercase("hello!"));
//            Console.WriteLine(IsUppercase("Hello "));
//            Console.WriteLine(IsLowercase("Hello World!"));
//            Console.WriteLine(IsLowercase("hello!"));
//            Console.WriteLine(isPasswordComplex("HelloWorld1"));
//        }

        private static bool isPasswordComplex(string v)
        {
            throw new NotImplementedException();
        }
         static string NormalizeString(String input)
        {
           return input.ToLower().Trim().Replace(", ", "");
        }
    

        static void Main1(string[] args)
        {
            Console.WriteLine(NormalizeString("Hello World!"));
        }
    }
}
