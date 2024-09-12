using System;

namespace Laboratorio5_1
{
    class PruebaVector1
    {

        private int[] sueldos;

        public void cargar()
        {
            for (int f = 0; f <= 5; f++)
            {
                Console.Write("Ingrese el sueldo del operario "+f+": ");
                string linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            Console.Write("Los 5 sueldos de los operarios \n");
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("["+sueldos[i]+"] ");
            }
        }

        static void Main(string[] args)
        { 
            PruebaVector1 pv = new();
            pv.cargar();
            pv.Imprimir(); 
        }
    }
}
