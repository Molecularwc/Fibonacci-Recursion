using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Recursion_Iterative_DynamicProgramming
{
    public static class DynamicRecursiveFib
    {
        public static int fib(int n)
        {
            int[] fibNum = new int[n + 2];

            fibNum[0] = 0;
            fibNum[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibNum[i] = fibNum[i - 1] + fibNum[i - 2];
            }

            return fibNum[n];
        }
    }
}
