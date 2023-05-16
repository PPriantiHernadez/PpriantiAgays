using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número 1:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2:");
            int numero2 = int.Parse(Console.ReadLine());

            if (EsPar(numero1))
            {
                Console.WriteLine(numero1 + " es un número par.");
            }
            else
            {
                Console.WriteLine(numero1 + " es un número impar.");
            }

            //Validar si el segundo número es par o impar
            if (EsPar(numero2))
            {
                Console.WriteLine(numero2 + " es un número par.");
            }
            else
            {
                Console.WriteLine(numero2 + " es un número impar.");
            }
            Console.ReadKey();
        }

        static bool EsPar(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
