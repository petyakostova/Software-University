// Write a program to find the longest word in a text. 
using System;
using System.Linq;              // needed for OrderByDescending()

class LongestWordInAText
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new char[] { ' ', '.', ',', ':', ';', '!', '"', '\'' }, StringSplitOptions.RemoveEmptyEntries);
                                                                
        string longestWord = words.OrderByDescending(s => s.Length).First();
        Console.WriteLine(longestWord);
    }
}