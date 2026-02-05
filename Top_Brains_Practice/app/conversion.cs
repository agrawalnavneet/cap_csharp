using System;

class Conv
{
   public static void conv()
    {
    
        int f = int.Parse(Console.ReadLine());
        double centimeters = FeetToCentimeters(f);
        Console.WriteLine(centimeters);
    }

    static double FeetToCentimeters(int f)
    {
        double cm = f * 30.48;
        return Math.Round(cm, 2, MidpointRounding.AwayFromZero);
    }
}
