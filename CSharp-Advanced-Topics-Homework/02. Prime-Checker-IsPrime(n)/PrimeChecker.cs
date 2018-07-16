// Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
using System;

class PrimeChecker
{
    static void Main()
    {
        long n;
        Console.Write("Enter an integer number n = ");
        while (!long.TryParse(Console.ReadLine(), out n))    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter an integer number n = ");
        }
        bool result = IsPrime(n);
        Console.WriteLine(result);
    }

    static bool IsPrime(long n)
    {        
        if ((n == 2) || (n == 5) || (n == -2) || (n == -5))
        {
            return true;
        }
        else
        {
            if ((n == 0) || (n == 1) || (n == -1) || (n % 2 == 0) || (n % 5 == 0))
            {
                return false;
            }
            else
            {
                if (n < 0)
                {
                    n = -n;
                }
                long maxDivider = (long)Math.Sqrt(n);                
                for (long div = 3; div <= maxDivider; div++)
                {
                    if (n % div == 0)
                    {
                        return false; 
                    }
                }
                return true;
            }            
        }       
    }
}