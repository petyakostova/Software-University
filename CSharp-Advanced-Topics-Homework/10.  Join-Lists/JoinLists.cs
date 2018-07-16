/* Write a program that takes as input two lists of integers and joins them. 
 * The result should hold all numbers from the first list, and all numbers from the second list, 
 * without repeating numbers, and arranged in increasing order. 
 * The input and output lists are given as integers, separated by a space, each list at a separate line.  */
using System;
using System.Collections.Generic;
using System.Linq;                          // needed for line 33 - Distinct()

class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Enter the first list of integers in a single line, separated by a space: ");
        List<string> firstList = new List<string>(Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries));
        Console.WriteLine("Enter the second list of integers in a single line, separated by a space: ");
        List<string> secondList = new List<string>(Console.ReadLine().Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries));
   
        firstList.AddRange(secondList);
        List<int> numbersList = new List<int>();
        for (int i = 0; i < firstList.Count; i++)
        {
            int n;
            if (!int.TryParse(firstList[i], out n))
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            numbersList.Add(n);
        }
        Console.WriteLine();
        numbersList = numbersList.Distinct().ToList();          // Distinct() erases the duplicated elements => using System.Linq
        numbersList.Sort();
        Console.WriteLine(string.Join(" ", numbersList));
    }
}