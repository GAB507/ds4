﻿using System;
using System.Collections.Generic;

namespace Laboratorio5_5
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine("Nombre: "+estudiante.Nombre+", Edad: "+estudiante.Edad);
            }
        }

        static List<Estudiante> estudiantes = new List<Estudiante>
        {
        new Estudiante {Nombre = "Ana" , Edad=12},
        new Estudiante {Nombre = "Juan" , Edad=10},
        new Estudiante {Nombre = "Sofia" , Edad=11}
         };

    }
     
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

}
