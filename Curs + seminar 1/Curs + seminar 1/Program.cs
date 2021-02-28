using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Curs___seminar_1
{
    class Program
    {

        /// <summary>
        /// Problema 4 
        /// </summary>
        /// <param name="args"></param>
        /// 
      
        static ulong suma_divizori(ulong n)
        {
            ulong s = n + 1;
            for (ulong i = 2; i <= n / 2; i++)
                if ((n % i) == 0)
                    s += i;
            return s;

        }

        /// <summary>
        /// pentru problema cu boabele de grau (tabla de sah)
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void grau(int []v, int tmp)
        {
            for (int i = 0; i <= 19; i++)
            {
                if (v[i] == tmp)
                    Console.Write(tmp + " ");
            }
        }

        /// <summary>
        /// Numere perfecte
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void perfecte(int tmp)
        {
            if (tmp == 6 || tmp == 28 || tmp == 496 || tmp == 8128)
                Console.Write(tmp + " ");
        }

        /// <summary>
        /// Perechile de numere prime intre ele (din foreach)
        /// </summary>
        static void perechi1(int []v, int tmp,int n)
        {
            v[n] = tmp;
            n++;
        }

        /// <summary>
        /// Perechile de numere prime intre ele (inafara foreach-ului)
        /// </summary>
        /// <param name="args"></param>

        static void perechi2(int []v, int n)
        {
            for(int i=0;i>n-1;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (cmmdc(v[i], v[j]) == 1)
                        Console.WriteLine(v[i] + " " + v[j]);
                }
            }
        }

        static int cmmdc(int a,int b)
        {
            while(a!=b)
            {
                if (a > b) a -= b;
                if (b > a) b -= a;
            }
            return a;
        }

        /// <summary>
        /// Accesare si Citire din fisier
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Fisier()
        {
            //accesare fisier
            TextReader load = new StreamReader(@"..\..\data in.txt");
            string buffer;
            int tmp;
            //citirea din fisier
            while ((buffer = load.ReadLine()) != null)
            {
                Console.WriteLine(buffer);

                //toata informatia din fisier afisata "cuvant cu cuvant" 
                string[] local = buffer.Split(' ');
                foreach (string s in local)
                {
                    Console.WriteLine(s);

                    tmp = int.Parse(s);

                    ///pentru problema cu boabele de grau
                    //grau(v,tmp);

                    ///pentru problema cu numere perfecte
                    //perfecte(tmp);

                    ///pentru problema cu perechile de nr prime intre ele
                    //perechi1(v,tmp,n);
                }
                ///pentru problema cu perechile de nr prime intre ele
                //perechi2(v,n);
            }
        }
        static void Main(string[] args)
        {
            //int []v={1,2,4,8,...} un fel de baza de date cu puterile lui 2
            //problema cu graul...tabla de sah


            
            int[] v = new int[20];
            int baza = 1;
            int n = 0;

            for (int i = 0; i <= 19; i++)
            {
                v[i] = baza;
                baza = baza * 2;
                //Console.Write(baza + " ");
            }

            Console.WriteLine("Puterile lui 2 pana la 1 mil:");
            for (int i = 0; i <= 19; i++)
                Console.Write(v[i] + " ");

            Console.WriteLine();
            Console.WriteLine();

            Fisier();
            
            
            Console.ReadKey();
        }

       
    }
}
