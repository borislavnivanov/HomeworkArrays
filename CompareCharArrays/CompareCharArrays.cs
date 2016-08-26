/*
 * Write a program that compares two char arrays lexicographically (letter by letter).
*/
using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter first word");
        string s1 = Console.ReadLine();
        char[] firstArray = s1.ToCharArray();

        Console.WriteLine("Enter second word");
        string s2 = Console.ReadLine();
        char[] secondArray = s2.ToCharArray();

        bool areIdentical = true;

        if (firstArray.Length != secondArray.Length)
        {
            Console.WriteLine("The two arrays have different sizes!");
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areIdentical = false;
                    break;
                }
            }

            if (areIdentical == true)
            {
                Console.WriteLine("The arrays are identical!");

            }
            else
            {
                Console.WriteLine("The arrays are different!");
            }

        }
    }
}
