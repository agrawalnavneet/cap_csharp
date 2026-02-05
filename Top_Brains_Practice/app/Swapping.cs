using System;

// Method 1 ref
class Refer
{
    static void SwapRef(ref int a, ref int b)
    {
        a = a + b;
        b = a - b;
        a = a - b;
    }

    public static void refer()
    {
        int x = 10;
        int y = 20;

        SwapRef(ref x, ref y);

        Console.WriteLine("After swap (ref): x = " + x + ", y = " + y);
    }
}



// Method: 2 out


// class Outer
// {
//     static void SwapOut(int a, int b, out int x, out int y)
//     {
//         x = b;
//         y = a;
//     }

//    public  static void outer()
//     {
//         int a = 5;
//         int b = 15;
//         int x, y;

//         SwapOut(a, b, out x, out y);

//         Console.WriteLine("After swap (out): x = " + x + ", y = " + y);
//     }
// }
