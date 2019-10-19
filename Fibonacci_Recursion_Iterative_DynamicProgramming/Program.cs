using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Recursion_Iterative_DynamicProgramming
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int firstRecFib, secondRecFib, thirdRecFib, fourthRecFib;

            firstRecFib = RecursiveFibonacci.fib(1, 0, 1);
            secondRecFib = RecursiveFibonacci.fib(6, 0, 1);
            thirdRecFib = RecursiveFibonacci.fib(10, 0, 1);
            fourthRecFib = RecursiveFibonacci.fib(20, 0, 1);

            Console.WriteLine("********************\nFibonacci Recirsion: \nn = 1:\t{0}\nn = 6:\t{1}\nn = 10:\t{2}\nn = 20:\t{3}\n********************", firstRecFib, secondRecFib, thirdRecFib, fourthRecFib);
            Console.ReadLine();
        }
    }
}
