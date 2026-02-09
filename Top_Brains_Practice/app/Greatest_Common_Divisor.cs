using System;

class Gcd
{
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;

        return GCD(b, a % b);
    }

   public  static void gcd()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int result = GCD(a, b);
        Console.WriteLine(result);
    }
}
