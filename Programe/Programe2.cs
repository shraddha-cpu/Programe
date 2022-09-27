using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public float Salary { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee[] Employees { get; set; }
    }

    internal class Programe2
    {
        static void Main(string[] args)
        {
           Employee[] emp1 = new Employee[]
          {
                new Employee {Id=1 ,Name = "Rahul", City = "Pune" ,Salary=67000},
               new Employee {Id=2, Name = "Rohan", City = "Mumbai" ,Salary=70000}
          };
            Employee[] emp2 = new Employee[]
            {
                new Employee {Id=1, Name = "Rahul", City = "Pune",Salary=50000 },
               new Employee {Id=2, Name = "Rohan", City = "Mumbai" ,Salary=65000},
               new Employee {Id=3, Name = "Kishor", City = "Nagpur",Salary=71000 }
            };
            Employee[] emp3 = new Employee[]
           {
                new Employee {Id=1, Name = "Dipali", City = "Pune",Salary=45000 },
               new Employee {Id=2 ,Name = "Minal", City = "Mumbai", Salary=55000},
               new Employee {Id=3, Name = "Ashwini", City = "Nagpur",Salary=56000 }
           };

           Department[] departments = new Department[]
            {
                new Department{Id=1,Name="C#",Employees=emp1 },
                new Department{Id=2,Name="Angular",Employees=emp2 },
                new Department{Id=3,Name="MVC",Employees=emp3 }
            };

            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.Id} {d.Name} ");
                foreach (Employee e in d.Employees)
                {
                    Console.WriteLine($"\t {e.Id} ->{e.Name} -> {e.City} ->{e.Salary}");
                }
            }

        }
    }
}
   
