using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el año:");
            int año = int.Parse(Console.ReadLine());

            bool esBisiesto = EsBisiesto(año);

            if (esBisiesto)
            {
                Console.WriteLine(año + " es un año bisiesto.");
            }
            else
            {
                Console.WriteLine(año + " no es un año bisiesto.");
            }
            Console.ReadKey();
        }
        static bool EsBisiesto(int año)
        {
            //Si es un año bisiesto se divide entre 4 y no puede entre 100. Tambien debe ser divisible entre 400
            return (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);
        }
    }
}
