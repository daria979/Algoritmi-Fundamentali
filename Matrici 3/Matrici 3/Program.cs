using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        /// <summary>
        /// zonele dintr-o matrice
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 9;
            int[,] a = new int[n, n];
            for(int i=0;i<9;i++)
            {
                for (int j = 0;j< 9;j++)
                {
                    if ((i < j) && (i + j < n - 1))
                        a[i, j] = 1;
                    if ((i < j) && (i + j > n - 1))
                        a[i, j] = 2;
                    if ((i > j) && (i + j < n - 1))
                        a[i, j] = 3;
                    if ((i > j) && (i + j > n - 1))
                        a[i, j] = 4;

                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    Console.Write(a[i, j]);
                Console.WriteLine();
            }
        }
    }
}
