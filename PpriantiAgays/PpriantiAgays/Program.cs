using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PpriantiAgays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n, i, edad, mayor, menor;

            Console.WriteLine("Ingrese la cantidad de personas: ");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("Ingrese las edades: ");

            i = 0;
            while(i < n)
            {
                edad = int.Parse(Console.ReadLine());

                if(edad > 18)
                {
                    mayor = edad;
                    Console.WriteLine("ES Mayor de edad" + mayor);
                    i++;
                }
                
            }
        }
    }
}
