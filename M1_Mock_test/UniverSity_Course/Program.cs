using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
       static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;
            Console.WriteLine("Welcome to University Course Registration System");
            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try{
                      switch (choice){
                    case "1":
                        Console.Write("Course Code: ");
                        string cCode = Console.ReadLine();

                        Console.Write("Course Name: ");
                        string cName = Console.ReadLine();

                        Console.Write("Credits: ");
                        int credits = int.Parse(Console.ReadLine());

                        Console.Write("Max Capacity: ");
                        int capacity = int.Parse(Console.ReadLine());

                        Console.Write("Prerequisites (comma separated): ");
                        string pre = Console.ReadLine();

                        List<string> prereqs = string.IsNullOrWhiteSpace(pre)
                            ? new List<string>()
                            : pre.Split(',').Select(p => p.Trim()).ToList();

                        system.AddCourse(cCode, cName, credits, capacity, prereqs);
                        Console.WriteLine("Course added successfully.");
                        break;
                    case "2":
                        Console.Write("Student ID: ");
                        string sId = Console.ReadLine();

                        Console.Write("Name: ");
                        string sName = Console.ReadLine();

                        Console.Write("Major: ");
                        string major = Console.ReadLine();

                        Console.Write("Max Credits: ");
                        int maxCredits = int.Parse(Console.ReadLine());

                        Console.Write("Completed Courses (comma separated): ");
                        string completed = Console.ReadLine();

                        List<string> completedCourses = string.IsNullOrWhiteSpace(completed)
                            ? new List<string>()
                            : completed.Split(',').Select(c => c.Trim()).ToList();

                        system.AddStudent(sId, sName, major, maxCredits, completedCourses);
                        Console.WriteLine("Student added successfully.");
                        break;
                    case "3":
                        Console.Write("Student ID: ");
                        string regSid = Console.ReadLine();

                        Console.Write("Course Code: ");
                        string regCode = Console.ReadLine();

                        Console.WriteLine(
                            system.RegisterStudent(regSid, regCode)
                            ? "Student registered successfully."
                            : "Registration failed."
                        );
                        break;

                    case "4":
                        Console.Write("Student ID: ");
                        string dropSid = Console.ReadLine();

                        Console.Write("Course Code: ");
                        string dropCode = Console.ReadLine();

                        Console.WriteLine(
                            system.DropStudent(dropSid, dropCode)
                            ? "Course dropped successfully."
                            : "Drop failed."
                        );
                        break;
                    case "5":
                        system.DisplayAllCourses();
                        break;
                    case "6":
                        Console.Write("Student ID: ");
                        string sid = Console.ReadLine();
                        system.DisplayStudentSchedule(sid);
                        break;

                    case "7":
                        system.DisplaySummary();
                        break;
                    case "8":
                        exit = true;
                        Console.WriteLine("Exiting system. Bye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;}}
                
                
                 catch (FormatException)
            {
                Console.WriteLine("Invalid number input.");
            }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

