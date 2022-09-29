using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class Collection
    {
        static void Main(string[] args)
        {
            /*       List<int> list1 = new List<int>();
                   list1.Add(10);


                   List<string> list2 = new List<string>();
                   list2.Add("Hello");

                   List<Product> list3 = new List<Product>();
                   list3.Add(new Product { Id = 1, Name = "Laptop", Price = 25000 });
                   // or

                   List<Product> products = new List<Product>()
                   {
                       new Product { Id = 1, Name = "Laptop", Price = 25000 },
                       new Product { Id = 2, Name = "Laptop", Price = 25000 },
                       new Product { Id = 3, Name = "Laptop", Price = 25000 },
                   };
                   products.CopyTo()
                   {

                   };
                   // Insert, CopyTo, Sort, Reverse , IndexOf, Count, Capacity
                   foreach (Product p in products)
                   {
                       Console.WriteLine(p);
                   }
               }
            */

  // 2.   (stcak)
  /*
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
           
            Console.WriteLine("Generic Stack Elements");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(".......");
           
            //  (pop)
               Console.WriteLine($"\nPop Element: {stack.Pop()}");
            //  (peek)
               Console.WriteLine($"\nPeek Element: {stack.Peek()}");
            //  (Reverse)
               Console.WriteLine($"\n Reverse element: {stack.Reverse()}");

            Console.ReadKey();
  */
  //  3. (Queue)
            
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("shraddha");
            queue.Enqueue("nikita");
            queue.Enqueue("kishori");
            queue.Enqueue("reva");
            Console.WriteLine("enter the element");
            foreach(var i in queue)
            {
                Console.WriteLine(i);
            }
            //  (Dequeue)
            Console.WriteLine($"\nDequeue Element: {queue.Dequeue()}");
            //  (count)
            Console.WriteLine($"\n:{queue.Count()}");
            //  (Gethashcode)
            Console.WriteLine($"\n:{queue.GetHashCode()}");
            //   (peek)
            Console.WriteLine($"\n:{queue.Peek()}");
            Console.ReadKey();


        }
    }
}
