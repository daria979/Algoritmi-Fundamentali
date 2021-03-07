using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] vn = new int[1001];

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1001);
            }

            for (int i = 0; i < n; i++)
            {
                vn[v[i]]++;
            }

            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();

            for (int i = 0; i < 1001; i++)
                Console.Write(vn[i] + " ");
            Console.WriteLine();

            for (int i = 0; i < 1001; i++)
                for (int j = 0; j < vn[i]; j++)
                    Console.Write(i + " ");
        }
    }
}
