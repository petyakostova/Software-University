// Define a method Fib(n) that calculates the n-th Fibonacci number. 
using System;

class NthFibonacciNumber
{
    /* Calculating the Fibonacci numbers consecutively. 
     * For this purpose we keep only the last two calculated elements of the sequence and use them to get the next element. */
    static void Main()
    {
        int n;
        Console.Write("Enter a number n = ");
        while ((!int.TryParse(Console.ReadLine(), out n)) || (n < 0))   // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number. Please enter an integer number: n >= 0");
            Console.Write("n = ");
        }
        long result = Fib(n);
        Console.WriteLine("Fib({0}) = {1}", n, result);
    }

    static long Fib(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            long memberN = 0;
            long memberNMinus1 = 1;
            long memberNMinus2 = 1;
            for (int i = 2; i <= n; i++)
            {
                memberN = memberNMinus2 + memberNMinus1;
                memberNMinus2 = memberNMinus1;
                memberNMinus1 = memberN;
            }
            return memberN;
        }
    }
}