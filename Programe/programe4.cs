using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    // generic class
    public class Test<T>
    {
        private T data;

        public void Accept(T data)
        {
            this.data = data;
        }
        public T Print()
        {
            return data;
        }

        internal class programe4
        {
            static void Main(string[] args)
            {
             /*   Test<int> obj1 = new Test<int>();
                obj1.Accept(10);

                Test<Product> obj2 = new Test<Product>();
                obj2.Accept(new Product { Id = 1, Name = "Mobile", Price = 9999 });

                Test<Employee> obj3 = new Test<Employee>();
                obj3.Accept(new Employee("Test", 34000, 200));

                Console.WriteLine(obj1.Print());
                Console.WriteLine(obj2.Print());
                Console.WriteLine(obj3.Print());
             */
            }
        }
        
    }
}
