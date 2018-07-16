/* Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
 * The letters should be listed in alphabetical order. Use the input and output format from the examples below. */
using System;
using System.Collections.Generic;           // needed for List<char> - line 16
using System.Text.RegularExpressions;       // needed for Regex - line 17
using System.Linq;                          // needed for Distinct() - line 16 and Count() - line 24

class CountOfLetters
{
    static void Main()
    {
        // first way
        Console.WriteLine("Enter list of letters on a line, separated by a space:");
        string input = string.Join("", Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));  // ToLower() => case-insensitiv

        List<char> uniqueLetters = input.Distinct().OrderBy(x => x).ToList();
        if (!Regex.IsMatch(input, @"^[a-z ]+$"))
        {
            Console.WriteLine("Invalid input. The list must contain only letters.");
            return;
        }
        foreach (char c in uniqueLetters)
        {
            Console.WriteLine("{0} -> {1}", c, input.Count(x => x == c));
        }

        //// other way
        //string[] letters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //Dictionary<string, int> letterCounter = new Dictionary<string, int>();

        //foreach (var letter in letters)
        //{
        //    int count = 0;
        //    if (letterCounter.ContainsKey(letter))
        //    {
        //        count = letterCounter[letter];
        //    }
        //    letterCounter[letter] = count + 1;
        //}

        //foreach (KeyValuePair<string, int> item in letterCounter.OrderBy(key => key.ToString()))
        //{
        //    Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        //}
    }
}