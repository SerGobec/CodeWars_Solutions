﻿namespace MeanSquareErrorLibrary
{
    /*
     * Task:
     * Complete the function that
        accepts two integer arrays of equal length
        compares the value each member in one array to the corresponding member in the other
        squares the absolute value difference between those two values
        and returns the average of those squared absolute value difference between each member pair.
     * 
     */
    public class Kata
    {
            public static double Solution(int[] firstArray, int[] secondArray)
            {
                return firstArray.Zip(secondArray).Select(el => Math.Pow(el.First-el.Second,2)).Sum() / firstArray.Length;
            }
    }
}