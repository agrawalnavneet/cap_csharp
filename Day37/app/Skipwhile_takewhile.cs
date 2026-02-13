using System;
using System.Linq;

class Take
{
    public static void take()
    {
        int[] numbers = { 2, 4, 6, 8, 1, 10 };

        var result = numbers.TakeWhile(n => n % 2 == 0);

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}


class Skip
{
    public static void skip()
    {
        int[] numbers = { 2, 4, 6, 8, 1, 10 };

        var result = numbers.SkipWhile(n => n % 2 == 0);

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}
