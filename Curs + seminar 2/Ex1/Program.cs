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
            int n1, n2;
            bool[] v1 = new bool[10];
            bool[] v2 = new bool[10];

            n1 = 2777134;
            n2 = 1115727789;

            while (n1 != 0)
            {
                v1[n1 % 10] = true;
                n1 /= 10;
            }

            while (n2 != 0)
            {
                v2[n2 % 10] = true;
                n2 /= 10;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(v1[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (v1[i] && v2[i])
                    Console.Write(i + " ");
            }
        }
    }
}
