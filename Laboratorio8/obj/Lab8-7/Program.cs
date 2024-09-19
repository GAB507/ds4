using System;

namespace Lab8_7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Corrio la aplicacion");

        }
    }

     sealed class ClaseBase
    {
        public void test() { }

        public void moreTesting() { }
    }

    // NO SE PUEDE SOBREESCRIBIR UNA CLASE DE TIPO SELLADA
    class ClaseHijo : ClaseBase
    {

    }


}
