using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Matrici_5
{
    public class Matrix
    {
        public float[,] values;
        public static Matrix Empty;
        public int n { get { return values.GetLength(0); } set { n = value; } }
        public int m { get { return values.GetLength(1); } set { m = value; } }

        public Matrix() { }
        public Matrix(int n, int m)
        {
            values=new float[n,m];
        }

        //citire din fisier
        public Matrix(string fileName, bool existD)
        {
            //intrebare: avem n si m sau numai datele?
            if(existD)
            {
                TextReader load = new StreamReader(fileName);
                string buffer = load.ReadLine();
                n = int.Parse(buffer.Split(' ')[0]);
                m = int.Parse(buffer.Split(' ')[1]);
                values = new float[n,m];
                for(int i=0;i<n;i++)
                {
                    string []T = load.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                        values[i, j] = int.Parse(T[j]);
                }
            }
        }

        //aleator      
        //citire din consola
        //primeste matricea values
        
        public Matrix multiply(Matrix toMulty)
        {
            if(this.m!=toMulty.n)
            {
                return Empty;
            }
            else
            {
                Matrix toReturn = new Matrix(this.n, toMulty.m);
                return toReturn;
            }
        }
        
        public List<string> view()
        {
            List<string> toReturn = new List<string>();
            string buffer;
            for(int i=0;i<n;i++)
            {
                buffer = "";
                for (int j = 0; j < m; j++)
                    buffer += values[i, j] + " ";
                toReturn.Add(buffer);
            }
            return toReturn;
        }

    }
    
}
