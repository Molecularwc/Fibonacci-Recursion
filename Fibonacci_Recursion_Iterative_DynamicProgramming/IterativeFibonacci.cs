using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Recursion_Iterative_DynamicProgramming
{
    public static class IterativeFibonacci
    {
        public static int Fib(int n)
        {
            int num = 0, num1 = 1, num2;
            if (n == 0)
                return num;
            for (int i = 2; i <= n; i++)
            {
                num2 = num + num1;
                num = num1;
                num1 = num2;
            }

            return num1;
        }
    }
}
