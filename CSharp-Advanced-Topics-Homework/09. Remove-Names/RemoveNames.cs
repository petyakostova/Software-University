/* Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
 * The input and output lists are given as words, separated by a space, each list at a separate line.  */
using System;
using System.Collections.Generic;             // needed for List<string> (line 12 & 15)
using System.Linq;                            // needed for Where (line 26)

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Enter the first list of names, given in a single line, separated by a space: ");
        List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] {' '},
            StringSplitOptions.RemoveEmptyEntries));
        Console.WriteLine("Enter the second list of names, given in a single line, separated by a space: ");
        List<string> secondList = new List<string>(Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries));

        // first way
        Console.WriteLine();        
        for (int i = 0; i < secondList.Count; i++)
        {
            firstList.RemoveAll(item => item == secondList[i]);
        }
        Console.WriteLine(string.Join(" ", firstList));

        //// second way
        //Console.WriteLine();
        //var outputList = firstList.Where(n => !secondList.Contains(n));     // Where needs using System.Linq;
        //Console.WriteLine(string.Join(" ", outputList));

        //// third way
        //Console.WriteLine();
        //for (int i = 0; i < secondList.Count; i++)
        //{
        //    for (int j = 0; j < firstList.Count; j++)
        //    {
        //        if (firstList.Contains(secondList[i]))
        //        {
        //            firstList.Remove(secondList[i]);
        //        }
        //    }
        //}
        //Console.WriteLine(string.Join(" ", firstList));
    }
}