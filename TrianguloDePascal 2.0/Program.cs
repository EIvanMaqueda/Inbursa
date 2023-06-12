using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloDePascal_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int num = int.Parse(Console.ReadLine());
            int[] resultados = new int[num+1];
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
                        
                        resultados[i] = suma;
                        
                        
                    }
                    //Console.WriteLine(suma);

                    suma = 0;
                }
                else
                {

                    Console.WriteLine("1");
                }
            }
            for (int j = 1; j < resultados.Length; j++)
            {
                Console.WriteLine(resultados[j]);
            }
            Console.ReadKey();
        }
    }
}
