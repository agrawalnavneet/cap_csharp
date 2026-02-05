using System;

class Height
{
   public  static void height()
    {
        int heightCm = int.Parse(Console.ReadLine());
        string category;

        if (heightCm < 150)
        {
            category = "Short";
        }
        else if (heightCm < 180)
        {
            category = "Average";
        }
        else
        {
            category = "Tall";
        }

        Console.WriteLine(category);
    }
}
