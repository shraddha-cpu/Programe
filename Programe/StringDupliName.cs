using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class StringDupliName
    {
        static void Main(string[] args)
        {
            String string1 = "Big black bug bit a big black dog on his big black nose";
            int count;
            string1 = string1.ToLower();
            String[] words = string1.Split(' ');

            Console.WriteLine("Duplicate words in a given string : ");
            for (int i = 0; i < words.Length; i++)
            {
                count = 1;
                for (int j = i+1; j < words.Length; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        count++;
                        words[j] = "0";
                    }
                }
                if (count > 1 && words[i] != "0")
                    Console.WriteLine(words[i]);
            }
        }
    }
 }

