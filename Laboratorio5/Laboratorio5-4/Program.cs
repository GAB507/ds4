using System;
using System.Collections.Generic;

namespace Laboratorio5_4
{
    class Program
    {
        static List<int> calificaciones = new List<int> { 85, 90, 78, 92, 88 };
        static int suma;

        static void Main(string[] args)
        {

            foreach (int calificacion in calificaciones)
            {
                suma += calificacion;
            }

            double promedio = suma / (double)calificaciones.Count;

            Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
        }


    }
}
