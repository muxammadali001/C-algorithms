using System;

namespace Algorithms
{
    static int findMiximum(int a, int b, int c)
    {
        if(a > b )
        {
            if (a > c || a == c)
            {
                return a;
            }
        }
        if(b > a)
        {
            if (b > c || b == c)
            {
                return b;
            }
        }
    }

}
