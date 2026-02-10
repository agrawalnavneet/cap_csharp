using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            if (AvailableCourses.ContainsKey(code))
                throw new ArgumentException("Course already exists.");

            Course course = new Course(code, name, credits, maxCapacity, prerequisites);
            AvailableCourses.Add(code, course);
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            if (Students.ContainsKey(id))
                throw new ArgumentException("Student already exists.");

            Student student = new Student(id, name, major, maxCredits, completedCourses);
            Students.Add(id, student);
        }

        // 🔁 Program.cs expects this name
        public bool RegisterStudent(string studentId, string courseCode)
        {
            return RegisterStudentForCourse(studentId, courseCode);
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return false;
            }

            if (!AvailableCourses.ContainsKey(courseCode))
            {
                Console.WriteLine("Course not found.");
                return false;
            }

            return Students[studentId].AddCourse(AvailableCourses[courseCode]);
        }

        // 🔁 Program.cs expects this name
        public bool DropStudent(string studentId, string courseCode)
        {
            return DropStudentFromCourse(studentId, courseCode);
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return false;
            }

            return Students[studentId].DropCourse(courseCode);
        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("\nAvailable Courses:");
            foreach (var course in AvailableCourses.Values)
            {
                Console.WriteLine(course.ToString());
            }
        }

        public void DisplayStudentSchedule(string studentId)
        {
            if (!Students.ContainsKey(studentId))
            {
                Console.WriteLine("Student not found.");
                return;
            }

            Students[studentId].DisplaySchedule();
        }

        // 🔁 Program.cs expects this name
        public void DisplaySummary()
        {
            DisplaySystemSummary();
        }

        public void DisplaySystemSummary()
        {
            Console.WriteLine("\nSystem Summary:");
            Console.WriteLine($"Total Students: {Students.Count}");
            Console.WriteLine($"Total Courses: {AvailableCourses.Count}");
        }
    }
}
