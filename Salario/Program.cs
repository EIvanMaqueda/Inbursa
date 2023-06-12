using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int saldoInicial = 13000;
            int op = int.Parse(Console.ReadLine());
            for (int i = 1; i <= op; i++)
            {
                int saldo = int.Parse(Console.ReadLine());
                saldoInicial = saldoInicial - saldo;
            }
            Console.WriteLine(saldoInicial);
            Console.ReadKey();

        }
    }
}
