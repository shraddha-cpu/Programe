using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    public class Emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
    public class Department
    {
        public int Did { get; set; }
        public string Dname { get; set; }

        public List<Emp> Employees = new List<Emp>();
    }

    internal class DepartEmployee
    {
        static void Main(string[] args)
        {
            List<Department> departmentList = new List<Department>()
            {
                new Department
                {
                    Did=101,Dname="HR",
                    Employees={
                        new Emp{EmpId=1,EmpName="User1"},
                        new Emp{EmpId=2,EmpName="User2"},
                    }
                },
                new Department
                {
                    Did=101,Dname="Development",
                    Employees={
                        new Emp{EmpId=3,EmpName="User3"},
                        new Emp{EmpId=4,EmpName="User4"},
                        new Emp{EmpId=5,EmpName="User5"},
                    }
                },

            };

            foreach (Department d in departmentList)
            {
                Console.WriteLine(d.Dname);
                foreach (Emp e in d.Employees)
                {
                    Console.WriteLine("\t"+e.EmpName);
                }
            }
        }
    }

