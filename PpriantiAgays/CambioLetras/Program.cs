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

            Console.WriteLine("Ingresar un palabra ");
            string palabra= Console.ReadLine();


            Console.Write("RESULTADO ES: " + program.Cambiar(palabra));

            Console.ReadKey();

        }


        public string Cambiar(string palabra)
        {
            //char[] alfabeto = { 'a', 'b', 'c', 'd', 'f' ,'g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z'};

           //private string cadena;
            Program program = new Program();

            int str = palabra.Length;
            Console.WriteLine(str);

            while (str >= 1)
            {
                palabra = program.Mid(palabra, str + 1);
                str++;
                
            }
            
            return palabra;
        }


        public string Mid(string param, int startIndex)
        {
            return param.Substring(startIndex, 1);
        }
    }
}
