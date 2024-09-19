using System;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trabajador p = new Trabajador("Josan", 22, "77588260-Z", 100000);
            Console.WriteLine("Nombre="+p.Nombre);
            Console.WriteLine("Edad="+p.Edad);
            Console.WriteLine("NIF="+p.NIF);
            Console.WriteLine("Sueldo=" + p.Sueldo);
            Console.ReadKey();


        }
    }


    public class Persona
    {

        public string Nombre;
        public int Edad;

        public string NIF;

        void Cumpleaños()
        {
            Edad++;
        }

        public Persona(string _Nombre, int edad, string nif)
        {
            Nombre = _Nombre;
            Edad = edad;
            NIF = nif;
        }


    }


    public class Trabajador : Persona
    {
        public int Sueldo;

        public Trabajador(string nombre , int edad , string nif, int sueldo):base(nombre, edad ,nif)
        {
            Sueldo = sueldo;
        }



    }

}
