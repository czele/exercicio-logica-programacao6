using System;
using System.Collections.Generic;
using System.Text;

namespace ex6
{
    public static class MDC
    {
        public static int Mdc (int a, int b)
        {
            int remain = 1;

            while (remain != 0)
            {
                remain = a % b;
                a = b;
                b = remain;
            }
            return a;

        }

    }
}
