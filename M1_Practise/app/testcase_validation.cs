using System;

public class TestCase
{
    public decimal Balance { get; private set; }

    public TestCase(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("Deposit amount cannot be negative");
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new Exception("Insufficient funds.");
        }

        Balance -= amount;
    }

    public static void testcase()
    {
        // Optional: manual test (not NUnit)
        TestCase account = new TestCase(1000);
        account.Deposit(500);
        Console.WriteLine(account.Balance); // Output: 1500
    }
}
