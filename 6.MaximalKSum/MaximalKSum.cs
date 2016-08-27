/*
Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */


using System;

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("Please enter value for N");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter {0} elements", n);
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter value for K");
        int k = int.Parse(Console.ReadLine());
        int[] result = new int[k];

        Array.Sort(arr);
        Array.Copy(arr, arr.Length - k, result, 0, k);

        int sum = 0;

        for (int i = 0; i < result.Length; i++)
        {
            sum += result[i];
        }

        Console.WriteLine("The sum of the largest integers is {0}", sum);
    }
}