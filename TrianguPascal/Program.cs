using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguPascal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op1 = Console.ReadLine();
            string[] numeros =op1.Split(' ');
            int[,] Pascal= new int[5,5];
            int[] suma = new int[5];
            int res = 0;
            int a=5;
            for (int i = 0; i < 5; i++)
            {
                Pascal[0, i] = 1;
                Pascal[i, 0] = 1;
            }
            for (int x = 1; x < 5; x++)
            {
                for (int y = 1; y < a; y++)
                {
                    Pascal[x, y] = Pascal[x - 1, y] + Pascal[x, y - 1];                  
                    //Console.Write(Pascal[x, y]);
                }
                a = a - 1;
                //Console.WriteLine("\n");
            }

            for (int w = int.Parse(numeros[0]); w < int.Parse(numeros[1]); w++)
            {
                //int restemp = 0;

                for (int z = 1; z <=w ; z++)
                {
                    suma[z] = Pascal[w,z-1]+ Pascal[z-1, w];                 
                }
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
