namespace Fibonacci_Recursion_Iterative_DynamicProgramming
{
    public static class RecursiveFibonacci
    {
        //Get the "nth" Fibonacci number recursively
        public static int fib(int n, int num, int num1)
        {
            if (n == 0)
                return num;
            if (n == 1)
                return num1;
            return fib(n - 1, num1, num + num1);
        }
    }
}
