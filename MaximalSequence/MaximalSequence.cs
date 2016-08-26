/*
Write a program that finds the maximal sequence of equal elements in an array.
Example:

input	result
2, 1, 1, 2, 3, 3, 2, 2, 2, 1	2, 2, 2
*/

using System;


class MaximalSequence
{
    static void Main()
    {
        int[] arr = new int[10] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int count = 0;
        int index = 0;
        int maxCount = 0;
        int maxIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1)
            {
                if (count > maxCount)
                {
                    maxCount = count;
                    maxIndex = index;
                }
                if (arr[i] == arr[i + 1])
                {
                    count++;
                    if(arr[i] != arr[index])
                    {
                        index = i;
                    }
                }
                else
                {
                    count = 0;
                    index = 0;
                }

            }
        }
        for (int i = maxIndex; i <= maxCount; i++)
        {
            Console.Write("{0}, ", arr[maxIndex]);
        }
    }
}
