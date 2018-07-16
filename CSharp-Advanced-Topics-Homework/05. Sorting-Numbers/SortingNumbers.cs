// Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 
using System;
using System.Collections.Generic;


class SortingNumbers
{
    static void Main()
    {
        uint n;
        Console.Write("Enter an integer number n = ");
        while (!uint.TryParse(Console.ReadLine(), out n))    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid number.");
            Console.Write("Please enter an integer number n = ");
        }
        List<int> numbers = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))    // parsing and input check (validating the user data)
            {
                Console.WriteLine("Invalid number.");
                Console.Write("Please enter an integer number = ");
            }
            numbers.Add(number);                
        }
        Console.WriteLine();
        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}