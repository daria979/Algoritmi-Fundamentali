using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[,] a = new int[n, n];
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n; j++)
                    a[i, j] = n-Math.Abs(n - (i + j + 1));
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
