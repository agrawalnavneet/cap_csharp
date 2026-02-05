using System;

// class Large
// {
//     public static void large()
//     {
//         int a = 10;
//         int b = 25;
//         int c = 15;

//         int largest = LargestInteger(a, b, c);
//         Console.WriteLine(largest);
//     }

//     static int LargestInteger(int a, int b, int c)
//     {
//         if (a >= b && a >= c)
//             return a;
//         else if (b >= a && b >= c)
//             return b;
//         else
//             return c;
//     }
// }




// taking user input

class Large1
{
    public static void large1()
    {
        Console.WriteLine(" first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("second number:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("third number:");
        int c = int.Parse(Console.ReadLine());

        int largest = LargestInteger(a, b, c);
        Console.WriteLine("Largest number is: " + largest);
    }

    static int LargestInteger(int a, int b, int c)
    {
        if (a >= b && a >= c)
            return a;
        else if (b >= a && b >= c)
            return b;
        else
            return c;
    }
}
