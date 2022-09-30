using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programe
{
    internal class ArrayZerostartEnd
    {
        static void Main(string[] args)
        {
            int[] A = { 5, 6, 0, 4, 6, 0, 9, 0, 8 };
              int n = A.Length;
              int j = 0;
              for (int i = 0; i < n; i++)
              {
                  if (A[i] != 0)
                  {
                      int temp = A[j];
                      A[j] = A[i];
                      A[i] = temp;
                      j++;
                  }
              }
              for (int i = 0; i < n; i++)
              {
                  Console.Write(A[i]);
                  Console.Write(" ");
              }
        }
    }
}

