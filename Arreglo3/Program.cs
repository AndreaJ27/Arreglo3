using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo3
{
    class Program
    {
        private float[] CaliQuimica;
        private float[] CaliFisica;

        public void quimica()
        {

            CaliQuimica = new float[4];
            for (int i=0; i<4; i++)
            {
                Console.WriteLine("Ingrese la calificacion #" + (i + 1) + "de quimica:");
                String lineaCaptura = Console.ReadLine();
                CaliQuimica[i] = int.Parse(lineaCaptura);
            }


        }

        public void fisica()
        {

            CaliFisica = new float[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese la calificacion #" + (i + 1) + "de fisica:");
                String lineaCaptura = Console.ReadLine();
                CaliFisica[i] = int.Parse(lineaCaptura);
            }
        }

        public void promedio()
        {

            float PromedioQ = 0;
            float PromedioF = 0;
            float promQ = 0;
            float promF = 0;

            for(int i=0; i<4; i++)
            {
                PromedioQ = PromedioQ + CaliQuimica[i];

            }

            for (int i = 0; i < 4; i++)
            {
                PromedioF = PromedioF + CaliFisica[i];


            }

            promQ = PromedioQ / 5;
            promF = PromedioF / 5;

            Console.WriteLine("El primedio de las calificaciones de quimica es:" + promQ + " y el de fisica es:" + promF);
            Console.ReadKey();

        }

        static void Main(string[] args)
        {

            Program promedios = new Program();
            promedios.quimica();
            promedios.fisica();
            promedios.promedio();

        }
    }
}
