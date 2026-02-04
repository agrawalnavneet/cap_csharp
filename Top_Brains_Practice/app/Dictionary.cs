using System;
using System.Collections.Generic;

// class Dict
// {
//    public  static void dict()
//     {
//         Dictionary<int, int> empSalary = new Dictionary<int, int>()
//         {
//             {1, 20000},
//             {4, 40000},
//             {5, 15000}
//         };

//         int[] ids = { 1, 4, 5 };
//         int totalSalary = 0;

//         foreach (int id in ids)
//         {
//             if (empSalary.ContainsKey(id))
//             {
//                 totalSalary += empSalary[id];
//             }
//         }

//         Console.WriteLine(totalSalary);
//     }
// }




class Dict
{
    public static void dict()
    {
        Dictionary<int, int> empSalary = new Dictionary<int, int>();

        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        // Taking dictionary input
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter EmployeeId: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Salary: ");
            int salary = int.Parse(Console.ReadLine());

            empSalary[id] = salary;
        }

        Console.Write("Enter number of Ids to calculate salary: ");
        int m = int.Parse(Console.ReadLine());

        int totalSalary = 0;

 
        for (int i = 0; i < m; i++)
        {
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());

            if (empSalary.ContainsKey(id))
            {
                totalSalary += empSalary[id];
            }
        }

        Console.WriteLine("Total Salary = " + totalSalary);
    }
}
