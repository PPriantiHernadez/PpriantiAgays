using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlazoDias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1 = new DateTime(2013, 02, 03);
            DateTime fecha2 = new DateTime(2013, 02, 28);

            DateTime fecha3 = new DateTime(2014, 01, 06);
            DateTime fecha4 = new DateTime(2014, 12, 31);

            DateTime fecha5 = new DateTime(2014, 12, 06);
            DateTime fecha6 = new DateTime(2015, 05, 23);

            // Calcular el plazo de días entre las dos fechas
            TimeSpan plazo = fecha2.Subtract(fecha1);
            int dias = (int)plazo.TotalDays;

            TimeSpan plazo1 = fecha4.Subtract(fecha3);
            int dias1 = (int)plazo1.TotalDays;

            TimeSpan plazo2 = fecha6.Subtract(fecha5);
            int dias2 = (int)plazo2.TotalDays;

            Console.WriteLine("El plazo de días entre la fecha " + fecha1.ToString("dd/MM/yyyy") + " y " + fecha2.ToString("dd/MM/yyyy") + " es: {0} días.", dias);
            Console.WriteLine("El plazo de días entre la fecha " + fecha3.ToString("dd/MM/yyyy") + " y " + fecha4.ToString("dd/MM/yyyy") + " es: {0} días.", dias1);
            Console.WriteLine("El plazo de días entre la fecha " + fecha5.ToString("dd/MM/yyyy") + " y " + fecha6.ToString("dd/MM/yyyy") + " es: {0} días.", dias2);
            Console.ReadKey();
        }
    }
}
