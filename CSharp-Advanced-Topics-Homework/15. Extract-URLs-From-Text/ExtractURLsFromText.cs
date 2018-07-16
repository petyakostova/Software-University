/* Write a program that extracts and prints all URLs from given text. URL can be in only two formats: 
 * http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com
 * www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com                      */
using System; 
using System.Text.RegularExpressions;     // needed for MatchCollection & Redex
//using System.Collections.Generic;           // needed forList<string>
//using System.IO;                            // needed for StreamReader  
//using System.Linq;                          // needed for Where(); Any()

class ExtractURLsFromText
{
    static void Main()
    {
        // first way
        string text = Console.ReadLine();
        MatchCollection urls = Regex.Matches(text, @"\b(?:http://|www\.)\S+\b");
        Console.WriteLine();
        foreach (var url in urls)
        {
            Console.WriteLine(url);
        }
        
        //// other way
        //Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
        //Console.WriteLine("Enter text:");
        //List<string> text = new List<string>(Console.ReadLine().Split(new char[] { ' ', ',', ';', '!', '"', }, StringSplitOptions.RemoveEmptyEntries));
        //List<string> words = new List<string> { "http://", "www." };
        //text = text.Where(s => words.Any(w => s.Contains(w))).Distinct().ToList();
        //if (text.Count == 0)
        //{
        //    Console.WriteLine("\nNo URLs in the text.");
        //    return;
        //}
        //Console.WriteLine("\nURLs in the text (no duplicates): ");
        //foreach (string url in text)
        //{
        //    Console.WriteLine(url.TrimEnd(new char[] { '.' }));
        //} 
    }
}