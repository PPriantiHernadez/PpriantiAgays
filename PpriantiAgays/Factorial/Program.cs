using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int fac = 1;
            Console.WriteLine("Ingresar un numero ");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                fac = fac * num;
                num = num - 1;
            }
            Console.WriteLine("El resultado es " + fac);
            Console.ReadKey();
        }
    }
}
