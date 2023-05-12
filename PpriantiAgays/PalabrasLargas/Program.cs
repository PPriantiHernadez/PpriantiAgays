using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabrasLargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Ingrese la frase: ");
            string frase = Console.ReadLine();

            Console.WriteLine("La palabra más larga de la cadena es: " + program.PalabraMasLarga(frase));
            Console.ReadKey();
        }
        public string PalabraMasLarga(string str)
        {
            // Dividir la cadena en palabras
            string[] palabras = str.Split(new char[] { ' ' });

            // Encontrar la longitud de la palabra más larga
            int longitudMaxima = palabras.Max(p => p.Length);

            // Encontrar la última palabra con la longitud máxima
            for (int i = palabras.Length - 1; i >= 0; i--)
            {
                if (palabras[i].Length == longitudMaxima)
                {
                    return palabras[i];
                }
            }
            return null;
        }


    }
}
