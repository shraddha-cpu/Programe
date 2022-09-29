using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class Programe3
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Test1");
            dictionary.Add(2, "Test2");

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine(item.Key+"  "+item.Value);
            }

            











        }
}
}
