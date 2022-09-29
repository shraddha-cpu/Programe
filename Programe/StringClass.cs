using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class StringClass
    {
        static void Main(string[] args)
        {
            string str1 = "  Sample Text in my current program ";
            string str2 = "some another text";
            int year = 2022;
            double per = 89.67;
            Console.WriteLine(str1.Length);
            Console.WriteLine(str2.Length);

            string str3 = str1.Substring(3);
            // string str3= str1.Substring(3,5);
            Console.WriteLine(str3);

            string str4 = String.Concat(str1, " ", str2, " ", "this is extra text added", " ", year.ToString(), per.ToString());
            Console.WriteLine(str4);
            char[] chars = str1.ToCharArray(2, 8);
            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str1.ToUpper());
            //str1.Trim();
            //str1.TrimStart();
            //str1.TrimEnd();

            bool result = str1.Contains("is");
            Console.WriteLine(result);

            string str5 = str1;
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str5.GetHashCode());


            bool result1 = str1.Equals(str5);
            bool result2 = str1.Equals(str2);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

        }
    }
}
