using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class StringBuil
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Hello to all");
            // Append  , AppendFormat  , Insert  , Remove , Replace
            float salary = 25000.00f;
            Console.WriteLine(stringBuilder);

            stringBuilder.Append(" My name is Rohan");
            Console.WriteLine(stringBuilder);

            stringBuilder.AppendFormat(" my salary is {0:C}", salary);
            Console.WriteLine(stringBuilder);

            stringBuilder.Insert(10, " HI ");
            Console.WriteLine(stringBuilder);

            stringBuilder.Replace("Rohan", "Suraj");

            Console.WriteLine(stringBuilder);

            stringBuilder.Remove(10, 5);
            Console.WriteLine(stringBuilder);

        }
    }
}
