/* Write a method that calculates all prime numbers in given range and returns them as list of integers.
 * Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line)
 * and prints all primes in their range, separated by a comma.*/
using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        long startNum;
        long endNum;
        Console.Write("Enter a start of the range: ");
        while (!long.TryParse(Console.ReadLine(), out startNum))    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter an integer number for the start of the range: ");
        }
        Console.Write("Enter an end of the range: ");
        while (!long.TryParse(Console.ReadLine(), out endNum))    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter an integer number for the end of the range: ");
        }
        if (startNum > endNum)
        {
            Console.WriteLine("(empty list)");
        }
        else
        {
            List<long> primesPrint = FindPrimesInRange(startNum, endNum);
            for (int i = 0; i < primesPrint.Count - 1; i++)
            {
                Console.Write("{0}, ", primesPrint[i]);
            }
            Console.WriteLine(primesPrint[primesPrint.Count - 1]);
        }        
        Console.WriteLine();
    }

    static List<long> FindPrimesInRange(long startNum, long endNum)
    {        
        List<long> primesList = new List<long>();
        for (long num = startNum; num <= endNum; num++)
		{
            bool prime = true;
            if (num == 0 || num == 1)
            {
                prime = false;
            }
            else
            {
                if (num < 0)
                {
                    num = -num;
                }
                long maxDivider = (long)Math.Sqrt(num);
                for (long div = 2; div <= maxDivider; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }
            }            
            if (prime)
	        {
                primesList.Add(num);                		    
	        }       
		}
        return primesList;   
    }
}