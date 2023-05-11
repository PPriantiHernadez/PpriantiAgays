using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenAlfabetico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar un palabra ");
            string palabra = Console.ReadLine();

            Program program = new Program();

            Console.WriteLine(program.ordenar(palabra));

            Console.ReadKey();
        }

        public string ordenar(string palabra)
        {
            palabra = String.Concat(palabra.OrderBy(ch => ch));

            return palabra;
        }
    }
}
