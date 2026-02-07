using System;

class Positive
{
    static int SumOfPositive(int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                break;

            if (nums[i] < 0)
                continue;

            sum += nums[i];
        }

        return sum;
    }

    public static void positive()
    {
        int[] nums = { 5, -2, 3, 0, 10 };
        Console.WriteLine(SumOfPositive(nums));
    }
}
