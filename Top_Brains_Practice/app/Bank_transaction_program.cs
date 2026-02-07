using System;

class BankTransaction
{
   public static void bank()
    {
        Console.Write("Enter initial balance: ");
        int balance = int.Parse(Console.ReadLine());

        Console.Write("Enter number of transactions: ");
        int n = int.Parse(Console.ReadLine());

        int[] transactions = new int[n];

        Console.WriteLine("Enter transactions:");
        for (int i = 0; i < n; i++)
        {
            transactions[i] = int.Parse(Console.ReadLine());
        }

        foreach (int t in transactions)
        {
            if (t >= 0)
            {
                balance += t;
            }
            else
            {
                if (balance + t >= 0)
                {
                    balance += t;
                }
            }
        }

        Console.WriteLine(balance);
    }
}
