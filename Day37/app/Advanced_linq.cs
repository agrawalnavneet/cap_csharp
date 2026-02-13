using System;

class Line{
public static void line()
{
    
List<int> numbers= new List <int>{10,20,30};

var deffered=numbers.Where(n=>n>15);
numbers.Add(50);

Console.WriteLine("\nDeffered Execution Result:");
foreach(var n in deffered)
        {
            Console.WriteLine(n);
        }
    Console.WriteLine();
}



// immediate execution

// var immediate=numbers.Where(n=>n>15).ToList();
// numbers.Add(50);

// Console.WriteLine("\nImmediate Execution Result:");
// foreach(var n in immediate)
//         {
//             Console.WriteLine(n);
//         }
//     Console.WriteLine();}
}