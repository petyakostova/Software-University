﻿/* Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence. 
 * In other words, you should remove a minimal number of numbers from the starting sequence, 
 * so that the resulting sequence is non-decreasing. 
 * In case of several longest non-decreasing sequences, print the leftmost of them. 
 * The input and output should consist of a single line, holding integer numbers separated by a space. Examples:
 * 
          Input                                        Output 
          1                                            1 
          7 3 5 8 -1 6 7                               3 5 6 7 
          1 1 1 2 2 2                                  1 1 1 
          1 1 1 3 3 3 2 2 2 2                          2 2 2 2 
          11 12 13 3 14 4 15 5 6 7 8 7 16 9 8          3 4 5 6 7 8 9                                */

// first way
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestNonDecreasingSeq
{
    static void Main()
    {
        //Input
        string input = Console.ReadLine();
        //Split the elements into an array
        string[] inputElements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //Fill an integer array from string array
        int[] elementsArray = new int[inputElements.Length];
        for (int i = 0; i < inputElements.Length; i++)
        {
            elementsArray[i] = int.Parse(inputElements[i]);
        }

        List<int> longestSequenceList = new List<int>();

        //Find the longest sequence of identical elements
        int startIndex = 0;
        int lenghtCount = 1;
        int currentCount = 1;

        for (int i = 0; i < elementsArray.Length - 1; i++) //could start on index 1 and check current with previous elements
        {
            if (elementsArray[i] == elementsArray[i + 1])
            {
                currentCount++;

                if (currentCount > lenghtCount)
                {
                    lenghtCount = currentCount;
                    startIndex = (i + 1) - (lenghtCount - 1);
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        //Make the sequence currently longest
        for (int i = 0; i < lenghtCount; i++)
        {
            longestSequenceList.Add(elementsArray[startIndex + i]);
        }

        //Find how many combinations of sequences can be there
        long combinations = 1;
        for (int i = 0; i < elementsArray.Length; i++) //Instead of Math.Pow
        {
            combinations *= 2;
        }

        for (long combination = 1; combination <= combinations; combination++)
        {
            //convert current combination number to its binary representation.
            //That way we will use the positions with bit "1" with the elements on the same position in the array
            string binary = Convert.ToString(combination, 2).PadLeft(elementsArray.Length, '0');
            char[] tempArr = binary.ToCharArray();
            Array.Reverse(tempArr);
            string revBinary = new string(tempArr);

            List<int> tempList = new List<int>();
            int bitsCount = 0;

            for (int i = 0; i < elementsArray.Length; i++)
            {
                if (revBinary[i] == '1')
                {
                    tempList.Add(elementsArray[i]);
                    bitsCount++;
                }
            }

            if (bitsCount < longestSequenceList.Count) //Speed optimisation
            {
                continue;
            }

            int currentLenght = 0;
            List<int> currentLongestSeq = new List<int>();

            if (tempList.Count > 1) //Avoid cases where the current combination will use only 1 element
            {
                int biggestNum = tempList[0];
                currentLongestSeq.Add(biggestNum);

                for (int i = 0; i < tempList.Count - 1; i++)
                {
                    //If the next number in the current combination sequence is bigger add it to final list
                    if (tempList[i + 1] > biggestNum)
                    {
                        biggestNum = tempList[i + 1];

                        currentLongestSeq.Add(biggestNum);
                    }
                }

                currentLenght = currentLongestSeq.Count;
            }

            if (currentLenght > longestSequenceList.Count)
            {
                longestSequenceList = currentLongestSeq;
            }
        }

        //Output
        for (int i = 0; i < longestSequenceList.Count; i++)
        {
            Console.Write(longestSequenceList[i] + " ");
        }
        Console.WriteLine();
    }
}


//// second way
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace LongestNonDecreasingSubsequence
//{
//    class SeqList
//    {
//        static int equalsFirstIndex;
//        static int increasingFirstIndex;

//        static void Main()
//        {
//            string input = Console.ReadLine();
//            input = input.Trim();
//            int[] arr = input.Split(' ').Select(s => int.Parse(s)).ToArray();
//            List<int> increasingSeq = getBestSequence(arr, false); //e.g:  1 2 3 4
//            List<int> equalSeq = getBestSequence(arr, true); //e.g:  1 1 1 1

//            if (increasingSeq.Count < equalSeq.Count ||
//                increasingSeq.Count == equalSeq.Count && increasingFirstIndex > equalsFirstIndex)
//            {
//                increasingSeq = new List<int>(equalSeq);
//            }

//            foreach (var item in increasingSeq)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();
//        }
//        //finds longest non-decreasing subsequence
//        static List<int> getBestSequence(int[] arr, bool equal)
//        {
//            List<int>[] lens = new List<int>[arr.Length];
//            int maxIndex = 0;

//            for (int currIndex = 0; currIndex < arr.Length; currIndex++)
//            {
//                bool expression;
//                lens[currIndex] = new List<int>();
//                lens[currIndex].Add(arr[currIndex]);
//                for (int prevIndex = 0; prevIndex < currIndex; prevIndex++)
//                {
//                    expression = arr[prevIndex] < arr[currIndex];
//                    if (equal == true)
//                    {
//                        expression = arr[prevIndex] == arr[currIndex];
//                    }

//                    if (expression &&
//                        lens[currIndex].Count <= lens[prevIndex].Count)
//                    {
//                        lens[currIndex] = new List<int>(lens[prevIndex]);
//                        lens[currIndex].Add(arr[currIndex]);

//                        if (lens[currIndex].Count > lens[maxIndex].Count)
//                        {
//                            maxIndex = currIndex;
//                        }
//                    }
//                }
//            }
//            if (equal == false)
//            {
//                increasingFirstIndex = maxIndex;
//            }
//            else
//            {
//                equalsFirstIndex = maxIndex;
//            }
//            return lens[maxIndex];
//        }
//    }
//}