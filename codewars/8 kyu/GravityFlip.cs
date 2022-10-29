// https://www.codewars.com/kata/5f70c883e10f9e0001c89673/csharp

using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static IEnumerable<int> Flip(char dir, int[] arr)
    {
        switch (dir)
        {
            case 'L':
                Array.Sort(arr);
                return arr.Reverse();
            case 'R':
                Array.Sort(arr);
                return arr;
            default:
                Console.WriteLine("Please enter a valid direction ('L' or 'R')");
                return arr;
        }
    }
}
