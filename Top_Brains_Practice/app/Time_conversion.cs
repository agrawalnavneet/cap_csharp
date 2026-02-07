using System;

class Time
{
   public  static void time()
    {
        int ts = 125;   

        int minutes = ts / 60;
        int seconds = ts % 60;

        string formatted = minutes + ":" + seconds.ToString("D2");

        Console.WriteLine(formatted);
    }
}
