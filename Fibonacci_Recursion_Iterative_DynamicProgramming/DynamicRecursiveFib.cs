namespace Fibonacci_Recursion_Iterative_DynamicProgramming
{
    public static class DynamicRecursiveFib
    {
        //Get the "nth" Fibonacci number recursively using dynamic programming
        public static int Fib(int n)
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
