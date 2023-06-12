using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Inbursa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int16 num = Convert.ToInt16(Console.ReadLine());
            if (num<=15)
            {
                int res=Factorial(num);
                Console.WriteLine(res);
            }
        }
        public static Int16 Factorial(Int16 num) {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt16(num) * Factorial( Convert.ToInt16(num) - Convert.ToInt16(1));
            }
        }
    }
}
