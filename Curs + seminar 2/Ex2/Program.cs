using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = 828952000111;
            ulong torMax = 0;
            ulong torMin = 0;

            int[] v = new int[10];

            while (n != 0)
            {
                v[n % 10]++;
                n /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(v[i] + " ");
            }

            for (int i = 9; i >= 0; i--)
            {
                if (v[i] != 0)
                {
                    for (int j = 0; j < v[i]; j++)
                        torMax = torMax * 10 + (ulong)i;
                }
            }
        }
    }
}
