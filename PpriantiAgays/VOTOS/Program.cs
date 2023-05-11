using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTOS
{
    public class VOTOS
    {


        static void Main(string[] args)
        {
            int[] candidatos = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la cantidad de votos del candidato : ");
                candidatos[i] = int.Parse(Console.ReadLine());
            }

            VOTOS vt = new VOTOS();

            vt.Acomodar(candidatos);

            Console.ReadKey();

        }

        public void Acomodar(int[] candidatos)
        {
            Array.Sort(candidatos);


            Console.WriteLine("Los votos ordenados por candidatos son:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(candidatos[i]);
            }
        }

        
       

      

    }
}
