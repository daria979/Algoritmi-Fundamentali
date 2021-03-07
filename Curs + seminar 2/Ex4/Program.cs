using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //1,2,3,4,...,998,999

            int n = 5000;
            int k = 7;
            int[] v = new int[n];
            int[] vNum = new int[n];


            for (int i = 0; i < n; i++)
            {
                if (v[i] >= 0 && v[i] <= 999)
                    vNum[v[i]]++;
                Console.Write(v[i] + " ");
            }

            Console.WriteLine("__________________________________");

            /*for (int i = 0; i < 1000; i++)
                Console.Write(vNum[i] + " ");*/

            for (int i = 0; i < 1000; i++)
            {
                if (vNum[i] == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
