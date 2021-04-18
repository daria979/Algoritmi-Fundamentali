using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdusMatrici
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix A = new Matrix(@"..\..\matrix1.txt", true);
            foreach (string s in A.view())
                Console.WriteLine(s);

            Matrix B = new Matrix(@"..\..\matrix2.txt", false);
            foreach (string s in B.view())
                Console.WriteLine(s);

            Matrix C = A.Add(B);
            if()
            foreach (string s in C.view())
                Console.WriteLine(s);
        }
    }
}
