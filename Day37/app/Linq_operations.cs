using System;
using System.Collections.Generic;
using System.Linq;

class Operate
{
    public static void operate()
    {
        List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

        // Filtering
        var greaterThan15 = numbers.Where(n => n > 15);

        // Projection
        var squares = numbers.Select(n => n * n);

        // Sorting
        var descending = numbers.OrderByDescending(n => n);

        // Aggregation
        var sum = numbers.Sum();
        var count = numbers.Count();

        // Element
        var first = numbers.First();

        // Partition
        var take3 = numbers.Take(3);

        // Set
        List<int> numbers2 = new List<int> { 15, 20, 100 };
        var common = numbers.Intersect(numbers2);

        Console.WriteLine("Greater than 15:");
        foreach (var n in greaterThan15)
            Console.WriteLine(n);

        Console.WriteLine("\nSquares:");
        foreach (var n in squares)
            Console.WriteLine(n);

        Console.WriteLine("\nDescending:");
        foreach (var n in descending)
            Console.WriteLine(n);

        Console.WriteLine("\nSum: " + sum);
        Console.WriteLine("Count: " + count);
        Console.WriteLine("First: " + first);

        Console.WriteLine("\nTake 3:");
        foreach (var n in take3)
            Console.WriteLine(n);

        Console.WriteLine("\nCommon Elements:");
        foreach (var n in common)
            Console.WriteLine(n);
    }
}
