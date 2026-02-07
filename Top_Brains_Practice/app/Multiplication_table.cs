using System;

class Multi
{
    static int[] MT(int n, int upto)
    {
        int[] result = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            result[i - 1] = n * i;
        }

        return result;
    }

   public  static void multi()
    {
        Console.Write("Enter number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter upto value: ");
        int upto = int.Parse(Console.ReadLine());

        int[] table = MT(n, upto);

        Console.WriteLine("Multiplication table:");
        Console.WriteLine(string.Join(", ", table));
    }
}
