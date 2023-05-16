using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la fecha: ");
            string fecha = Console.ReadLine();

            string dia = fecha.Substring(0, 2);
            string mes = fecha.Substring(2, 2);
            string año = fecha.Substring(4);

            var meses = new Dictionary<string, string>
        {
            { "01", "enero" },
            { "02", "febrero" },
            { "03", "marzo" },
            { "04", "abril" },
            { "05", "mayo" },
            { "06", "junio" },
            { "07", "julio" },
            { "08", "agosto" },
            { "09", "septiembre" },
            { "10", "octubre" },
            { "11", "noviembre" },
            { "12", "diciembre" }
        };

            string fechaOrdenada = $"{dia} de {meses[mes]} de {año}";

            Console.WriteLine(fechaOrdenada);
            Console.ReadKey();
        }
    }
}
