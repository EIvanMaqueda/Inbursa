using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero=int.Parse(Console.ReadLine());
            if (numero < 15)
            {
                int factorial = numero;
                for (int i = 1; i < numero; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine(factorial);
            }
            else
            {
                
            }
        }
    }
}
