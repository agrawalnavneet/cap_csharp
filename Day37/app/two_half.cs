using System;
using System.Collections.Generic;
using System.Linq;

class Half
{
    public static void half()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        int half = numbers.Count / 2;

        List<int> firstHalf = numbers.Take(half).ToList();
        List<int> secondHalf = numbers.Skip(half).ToList();
  
  // print half
        Console.WriteLine("First Half:");
        foreach (int num in firstHalf)
        {
            Console.Write(num + " ");}
        Console.WriteLine();

        // Print another half
        Console.WriteLine("Second Half:");
        foreach (int num in secondHalf)
        {
            Console.Write(num + " ");}}}
        


