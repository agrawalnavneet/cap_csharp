using System;

class Nul
{
    static double? AverageNonNull(double?[] values)
    {
        double sum = 0;
        int count = 0;

        foreach (double? v in values)
        {
            if (v != null)
            {
                sum += v.Value;
                count++;
            }
        }

        if (count == 0)
            return null;

        double avg = sum / count;
        return Math.Round(avg, 2, MidpointRounding.AwayFromZero);
    }

    public static void nul()
    {
        double?[] values = { 10.5, null, 20.25, null, 5 };

        double? result = AverageNonNull(values);

        if (result == null)
            Console.WriteLine("null");
        else
            Console.WriteLine(result);
    }
}
