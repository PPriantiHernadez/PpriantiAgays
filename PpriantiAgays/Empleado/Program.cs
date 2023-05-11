using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de dias trabajados Jacobo: ");
            int j = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dias trabajados Alvaro: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dias trabajados Mario: ");
            int m = int.Parse(Console.ReadLine());

            int jacobo = 500;
            int alvaro = 400;
            int mario = 300;
            
            int CalculasueldoJacobo = CalculaSueldo(j,jacobo);
            int CalculasueldoAlvaro = CalculaSueldo(a,alvaro);
            int CalculasueldoMArio = CalculaSueldo(m,mario);

            Empleado empleado = new Empleado();
            empleado.Nombre = "Jacobo";
            empleado.Apellido = "Agami";


            Console.WriteLine("nombre"+empleado.Nombre+" "+empleado.Apellido+"Sueldo total"+CalculasueldoJacobo);
            Console.WriteLine("Alvaro Gonzalez Sueldo total"+CalculasueldoAlvaro);
            Console.WriteLine("Mario Ramon sueldo total"+CalculasueldoMArio);

            Console.ReadKey();
        }

        public class Empleado
        {
            private string _Nombre;
            private string _Apellido;
            private int _SueldoDiario;

            public string Nombre { get => _Nombre; set => _Nombre = value; }
            public string Apellido { get => _Apellido; set => _Apellido = value; }
            public int SueldoDiario { get => _SueldoDiario; set => _SueldoDiario = value; }

        }

        public static int CalculaSueldo(int dias, int SueldoDaiario)
        {
            int total = dias * SueldoDaiario;

            return total;

        }


    }
}
