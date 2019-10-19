using System;

namespace Fibonacci_Recursion_Iterative_DynamicProgramming
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Get the recursive values
            var firstRecFib = RecursiveFibonacci.fib(1, 0, 1);
            var secondRecFib = RecursiveFibonacci.fib(6, 0, 1);
            var thirdRecFib = RecursiveFibonacci.fib(10, 0, 1);
            var fourthRecFib = RecursiveFibonacci.fib(20, 0, 1);

            //Get the iterative values
            var iterativeFib1 = IterativeFibonacci.Fib(1);
            var iterativeFib2 = IterativeFibonacci.Fib(6);
            var iterativeFib3 = IterativeFibonacci.Fib(10);
            var iterativeFib4 = IterativeFibonacci.Fib(20);

            //Get the dynamic recursive values
            var dynamicFib1 = DynamicRecursiveFib.fib(1);
            var dynamicFib2 = DynamicRecursiveFib.fib(6);
            var dynamicFib3 = DynamicRecursiveFib.fib(10);
            var dynamicFib4 = DynamicRecursiveFib.fib(20);

            Console.WriteLine("***************\nFibonacci Recursion: \nn = 1:\t{0}\nn = 6:\t{1}\nn = 10:\t{2}\nn = 20:\t{3}\n***************", firstRecFib, secondRecFib, thirdRecFib, fourthRecFib);
            Console.WriteLine("Fibonacci Iteration: \nn = 1:\t{0}\nn = 6:\t{1}\nn = 10:\t{2}\nn = 20:\t{3}\n***************", iterativeFib1, iterativeFib2, iterativeFib3, iterativeFib4);
            Console.WriteLine("Fibonacci Dynamic Recursion: \nn = 1:\t{0}\nn = 6:\t{1}\nn = 10:\t{2}\nn = 20:\t{3}\n***************", dynamicFib1, dynamicFib2, dynamicFib3, dynamicFib4);

            Console.ReadLine();
        }
    }
}
