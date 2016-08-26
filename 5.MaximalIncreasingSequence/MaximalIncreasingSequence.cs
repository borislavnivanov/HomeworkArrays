/*
 * Write a program that finds the maximal increasing sequence in an array.
Example:

input       	         result
3, 2, 3, 4, 2, 2, 4	     2, 3, 4
*/
using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] input = new int[] { 3, 2, 3, 4, 2, 2, 4 };
        //int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        List<int> count = new List<int>();
        List<int> maxCount = new List<int>();
        int checkIndex = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if ((checkIndex + 1) < input.Length)
            {
                checkIndex++;
            }
            if (input[i] == input[checkIndex] - 1)
            {
                if (count.Count == 0)
                {
                    count.Add(input[i]);
                }
                count.Add(input[checkIndex]);
            }
            else
            {
                if (count.Count > maxCount.Count)
                {
                    maxCount.AddRange(count);
                }
                count.Clear();
            }
            
            
        }
        for (int i = 0; i < maxCount.Count; i++)
        {
            Console.Write("{0}, ",maxCount[i]);
        }
    }
}
