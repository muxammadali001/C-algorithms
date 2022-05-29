// using System;

// class Program
// {
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

// }
