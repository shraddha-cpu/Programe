using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    public class Student
    {
        public string StudName { get; set; }
        public string City { get; set; }
    }
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public Student[] Students { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stud1 = new Student[]
           {
                new Student { StudName = "Rahul", City = "Pune" },
               new Student { StudName = "Rohan", City = "Mumbai" }
           };
            Student[] stud2 = new Student[]
            {
                new Student { StudName = "Rahul", City = "Pune" },
               new Student { StudName = "Rohan", City = "Mumbai" },
               new Student { StudName = "Kishor", City = "Nagpur" }
            };
            Student[] stud3 = new Student[]
           {
                new Student { StudName = "Dipali", City = "Pune" },
               new Student { StudName = "Minal", City = "Mumbai" },
               new Student { StudName = "Ashwini", City = "Nagpur" }
           };

            Course[] courses = new Course[]
            {
                new Course{Id=1,Name="C#",Fees=20000,Students=stud1 },
                new Course{Id=2,Name="Angular",Fees=20000,Students=stud2 },
                new Course{Id=3,Name="MVC",Fees=20000,Students=stud3 }
            };

            foreach (Course c in courses)
            {
                Console.WriteLine($"{c.Id} {c.Name}  {c.Fees}");
                foreach (Student s in c.Students)
                {
                    Console.WriteLine($"\t {s.StudName} -> {s.City}");
                }
            }

        }
    }
}
