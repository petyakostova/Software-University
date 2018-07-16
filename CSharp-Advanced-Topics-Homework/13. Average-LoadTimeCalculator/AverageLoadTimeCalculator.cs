/* We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below.
 * Your tasks is to calculate the average load time for each URL. 
 * Print the URLs in the same order as they first appear in the input report. 
 * Print the output in the format given below. Use double floating-point precision.  
         Input	                                            Output
        2014-Mar-02 11:33 http://softuni.bg 8.37725         http://softuni.bg -> 7.813625
        2014-Mar-02 11:34 http://www.google.com 1.335       http://www.google.com -> 2.24875
        2014-Mar-03 21:03 http://softuni.bg 7.25
        2014-Mar-03 22:00 http://www.google.com 2.44
        2014-Mar-03 22:01 http://www.google.com 2.45
        2014-Mar-03 22:01 http://www.google.com 2.77

        2014-Apr-01 02:01 http://softuni.bg 8.37725         http://softuni.bg -> 5.3695625
        2014-Apr-01 02:05 http://www.nakov.com 11.622       http://www.nakov.com -> 11.3706666666667
        2014-Apr-01 02:06 http://softuni.bg 4.33            http://www.google.com -> 2.21758333333333
        2014-Apr-01 02:11 http://www.google.com 1.94
        2014-Apr-01 02:11 http://www.google.com 2.011
        2014-Apr-01 02:12 http://www.google.com 4.882
        2014-Apr-01 02:34 http://softuni.bg 4.885
        2014-Apr-01 02:36 http://www.nakov.com 10.74
        2014-Apr-01 02:36 http://www.nakov.com 11.75
        2014-Apr-01 02:38 http://softuni.bg 3.886
        2014-Apr-01 02:44 http://www.google.com 1.04
        2014-Apr-01 02:48 http://www.google.com 1.4555
        2014-Apr-01 02:55 http://www.google.com 1.977                                   */
using System;
using System.Globalization;                                 // necessary for the line 34 - CultureInfo
using System.Threading;                                     // necessary for the line 34 - Thread
using System.Collections.Generic;
using System.Linq;                                          // needed for Distinct()

class AverageLoadTimeCalculator
{
    static void Main()
    {
        // changing the culture of the program in American standard so the decimal point character is . 
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        string line = Console.ReadLine();
        Dictionary<string, double> sumOfTime = new Dictionary<string, double> ();
        Dictionary<string, int> countOfLoads=new Dictionary<string, int>();
 
        while (line != string.Empty)
        {
            string[] list = line.Split(' ');
            string link = list[2];
            double loadTime = double.Parse(list[3], CultureInfo.InvariantCulture);
            if (!sumOfTime.Keys.Contains(link))
            {
                sumOfTime[link] = loadTime;
                countOfLoads[link] = 1;
            }
            else
            {
                sumOfTime[link] = sumOfTime[link] + loadTime;
                countOfLoads[link]++;
            }
            line = Console.ReadLine();
        }
 
        foreach (string link in sumOfTime.Keys)
        {
            Console.WriteLine(link + " --> " + sumOfTime[link]/countOfLoads[link]);
        }
    } 
}