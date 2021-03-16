using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        /// <summary>
        /// Matricea de dimensiune n*m de numere prime
        /// </summary>
        /// <param name="args"></param>
        /// 
        static bool isPrim(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            if(n%2!=0)
                for (int i = 3; i * i <= n; i += 2)
                    if ((n % i) == 0)
                        return false;
            return true;
        }
        static void Main(string[] args)
        {
            int idx = 2;
            int nr = 0,lc=0,cc=0;
            int n = 5;
            int m = 2;
            int[,] a = new int[n, m];
            do
            {
                if (isPrim(idx))
                {
                    a[lc, cc] = idx;
                    cc++;
                    if(cc==m)
                    {
                        cc = 0;
                        lc++;
                    }
                    nr++;
                }       
                idx++;
            } while (nr < (n * m));

            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
