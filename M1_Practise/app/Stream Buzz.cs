using System;
using System.Collections.Generic;

public class CreatorStats
{
    public string CreatorName { get; set; } = "";
    public double[] WeeklyLikes { get; set; } = new double[4];
}

public class Stream
{
    public static List<CreatorStats> EngagementBoard = new List<CreatorStats>();

    public void RegisterCreator(CreatorStats record)
    {
        EngagementBoard.Add(record);
    }

    public Dictionary<string, int> GetTopPostCounts(List<CreatorStats> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (CreatorStats creator in records)
        {
            int count = 0;

            foreach (double likes in creator.WeeklyLikes)
            {
                if (likes >= likeThreshold)
                    count++;
            }

            if (count > 0)
                result.Add(creator.CreatorName, count);
        }

        return result;
    }

    public double CalculateAverageLikes()
    {
        double total = 0;
        int weeks = 0;

        foreach (CreatorStats creator in EngagementBoard)
        {
            foreach (double like in creator.WeeklyLikes)
            {
                total += like;
                weeks++;
            }
        }

        return weeks == 0 ? 0 : total / weeks;
    }
}

public class Stream
{
    public static void stream()
    {
        Stream stream = new Stream();
        int choice;

        do
        {
            Console.WriteLine("1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreatorStats creator = new CreatorStats();

                    Console.WriteLine("Enter Creator Name:");
                    creator.CreatorName = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");
                    for (int i = 0; i < 4; i++)
                        creator.WeeklyLikes[i] = Convert.ToDouble(Console.ReadLine());

                    stream.RegisterCreator(creator);
                    Console.WriteLine("Creator registered successfully\n");
                    break;

                case 2:
                    Console.WriteLine("Enter like threshold:");
                    double threshold = Convert.ToDouble(Console.ReadLine());

                    var result = stream.GetTopPostCounts(Stream.EngagementBoard, threshold);

                    if (result.Count == 0)
                        Console.WriteLine("No top-performing posts this week");
                    else
                        foreach (var item in result)
                            Console.WriteLine(item.Key + " - " + item.Value);

                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine("Overall average weekly likes: " +
                        stream.CalculateAverageLikes());
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    break;
            }

        } while (choice != 4);
    }
}
