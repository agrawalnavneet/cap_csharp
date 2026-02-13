using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Arr
{
   public  static void arr()
    {
        ArrayList list = new ArrayList() { 1, "Navneet", "btech", 3000 };
        IEnumerable<int> numbers = list.OfType<int>();

        Console.WriteLine("Integers in ArrayList:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine();

        string[] names = { "Anu", "Arjun", "Ravi", "Amit", "Rahul", "Aishu" };
        IEnumerable<string> startWithA = names
                                            .Where(n => n.StartsWith("A"));

        Console.WriteLine("Names start with A:");
        foreach (string name in startWithA)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();

        // Names ending with 'u' and add 'n'
        IEnumerable<string> endWithU = names
                                        .Where(n => n.EndsWith("u"))
                                        .Select(n => n + "mr");

        Console.WriteLine("Names ending with 'u' and added 'n':");
        foreach (string name in endWithU){
            Console.WriteLine(name);
        }
    }
}
