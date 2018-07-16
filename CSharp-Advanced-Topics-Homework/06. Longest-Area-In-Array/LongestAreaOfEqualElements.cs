/* Write a program to find the longest area of equal elements in array of strings. 
 * You first should read an integer n and n strings (each at a separate line), 
 * then find and print the longest sequence of equal elements (first its length, then its elements). 
 * If multiple sequences have the same maximal length, print the leftmost of them.  */
using System;
using System.Collections.Generic;

class LongestAreaOfEqualElements
{
    static void Main()
    {
        uint n;
        Console.Write("Enter an integer number n = ");
        while (!uint.TryParse(Console.ReadLine(), out n))    // parsing and input check (validating the user data)
        {
            Console.WriteLine("Invalid Number.");
            Console.WriteLine("Please enter an integer number n = ");
        }
        string[] strings = new string[n];
        for (int i = 0; i < strings.Length; i++)
		{
            strings[i] = Console.ReadLine();			 
		}
        List<string> longestArea = new List<string>() { strings[0] };
        int maxLength = 1;
        for (int i = 0; i < strings.Length; i++)
        {
            int count = 1;            
            for (int j = i+1; j < strings.Length; j++)
            {
                if (strings[i] != strings[j])
                {
                    break;
                }
                count++;
            }
            if (count > 1 && count > maxLength)
            {
                longestArea.Clear();
                for (int c = 0; c < count; c++)
                {
                    longestArea.Add(strings[i]);
                }
                maxLength = count;
            }
        }
        Console.WriteLine();
        Console.WriteLine(longestArea.Count);
        for (int i = 0; i < longestArea.Count; i++)
        {
            Console.WriteLine(longestArea[i]);
        }
    }
}