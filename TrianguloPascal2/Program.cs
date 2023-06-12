using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloPascal2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                string op1 = Console.ReadLine();
                string[] numeros = op1.Split(' ');

                if (numeros.Length > 1)
                {
                    for (int x = int.Parse(numeros[0]); x <= int.Parse(numeros[1]); x++)
                    {
                        double potencia = Math.Pow(2, x);
                        suma = suma + (int)potencia;
                    }
                    Console.WriteLine(suma);
                    suma = 0;
                }
                else
                {

                    Console.WriteLine("1");
                }
            }
            Console.ReadKey();
        }
    }
}
