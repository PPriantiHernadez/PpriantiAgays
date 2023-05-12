using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CambioLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine("Ingrese la palabra: ");
            string palabra = Console.ReadLine();

            Console.WriteLine("La palabra: " + palabra + " = " + program.CambioLetras(palabra));
            Console.ReadKey();
        }

        public string CambioLetras(string str)
        {
            // Convertir la cadena en un arreglo de caracteres
            char[] letras = str.ToCharArray();

            // Reemplazar cada letra por la letra que sigue en el alfabeto
            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] >= 'a' && letras[i] < 'z')
                {
                    letras[i] = (char)(letras[i] + 1);
                }
                else if (letras[i] == 'z')
                {
                    letras[i] = 'a';
                }
                else if (letras[i] >= 'A' && letras[i] < 'Z')
                {
                    letras[i] = (char)(letras[i] + 1);
                }
                else if (letras[i] == 'Z')
                {
                    letras[i] = 'A';
                }
            }

            // Convertir el arreglo de caracteres de nuevo a una cadena
            string resultado = new string(letras);

            return resultado;
        }


    
}
}
