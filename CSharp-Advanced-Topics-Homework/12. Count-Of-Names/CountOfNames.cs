/* Write a program that reads a list of names and prints for each name how many times it appears in the list. 
 * The names should be listed in alphabetical order. Use the input and output format from the examples below. 
        Input	                                Output
        Peter Steve Nakov Steve Alex Nakov	    Alex -> 1
                                                Nakov -> 2
                                                Peter -> 1
                                                Steve -> 2
 * 
        Nakov Nakov Nakov SoftUni Nakov	        SoftUni -> 1
                                                Nakov -> 5                                      */
using System;
using System.Collections.Generic;           // needed for List<string>
using System.Linq;                          // needed for Distinct() and Count()

class CountOfNames
{
    static void Main()
    {
        Console.WriteLine("Enter list of names in a single line, separated by a space:");
        List<string> input = new List<string>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

        List<string> names = input.Distinct().OrderBy(c => c).ToList();

        foreach (string name in names)
        {
            Console.WriteLine("{0} -> {1}", name, input.Count(x => x == name));
        }
    }
}