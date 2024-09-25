using System;
using System.Threading.Tasks;
using System.Collections.Generic; 
using System.Linq;
using System.Text;

namespace Laboratorio9
{
    class problema4
    {
        public Aleatorios aleatorio;

        public void problema_4()
        {
            Aleatorios alea = new();

            alea.GenerarNumero(5,20);
            alea.GenerarArreglo();
             
        }
    }


    public class Aleatorios
    {
        private Random rand=new Random();
 
        public void GenerarNumero(int n1 , int n2)
        {
            int num = rand.Next(n1, n2);

            Console.WriteLine("El numero generado es: "+num);

        }

        public void GenerarArreglo()
        {
            int []arreglo = new int[20];

            for (int i = 0; i < 20; i++)
            {
                arreglo[i] = rand.Next(i);
            }

            Console.WriteLine("El arreglo generado es: ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(arreglo[i]+",");
            }

        }

        public void GenerarArregloNoRepetido()
        {
            int[] arreglo = new int[20];
            int j = 0;
            Random rand = new Random();

            for (int i = 0; i < arreglo.Length; i++) 
            {
                arreglo[i] = rand.Next(1, 30);  
                 
                while (j < i)   
                {
                    if (arreglo[j] == arreglo[i])  
                    {
                        arreglo[i] = rand.Next(1, 30);  
                        j = 0; 
                    }
                    else
                    {
                        j++;
                    }
                }
                j = 0;  
            }

            Console.WriteLine("El arreglo generado no repetido es: ");
            foreach (var item in arreglo)
            {
                Console.Write(item + ",");
            }

        }

    }


}
