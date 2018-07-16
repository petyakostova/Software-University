// Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Enter the first date (dd.mm.yyyy) : ");
        DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Enter the second date (dd.mm.yyyy) : ");
        DateTime secondDate = Convert.ToDateTime(Console.ReadLine());
        TimeSpan daysBetweenTheDates = secondDate - firstDate;
        Console.WriteLine(daysBetweenTheDates.TotalDays);
    }
}