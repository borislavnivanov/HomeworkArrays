/*
 * Write a program that reads two integer arrays from the console and compares them element by element.
*/

using System;


class CompareArrays
{
    static void Main()
    {
        int arraySize;
        Console.WriteLine("Please enter the size of the array");
        arraySize = int.Parse(Console.ReadLine());
        int[] firstArray = new int[arraySize];
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        int arraySize2;
        Console.WriteLine("Please enter the size of the array");
        arraySize2 = int.Parse(Console.ReadLine());
        int[] secondArray = new int[arraySize2];
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        if (arraySize != arraySize2)
        {
            Console.WriteLine("the arrays have different size");
        }
        else
        {

            int index = 0;

            bool isTheSame = true;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isTheSame = false;
                    index = i;
                }
            }

            if (isTheSame == true)
            {
                Console.WriteLine("The arrays are identical");
            }
            else
            {
                Console.WriteLine("The arrays are different at index {0}, value first array = {1}, value second array = {2}", index, firstArray[index], secondArray[index]);
            }
        }

    }
}

