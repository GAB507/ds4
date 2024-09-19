using System;

namespace Lab8_6
{
    public class ClaseBase
    {
        public void test()
        {
        }

        // Metodo sellado no puede ser PORQUE DEBE DERIVAR DE UNA CLASE BASE, CON EL METODO VIRTUAL
        public sealed void masTests()
        {
        }
    }

    class ClaseHijo : ClaseBase
    {
        // No es posible sobrescribir masTests() porque es sealed
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Corrió la aplicación");
        }
    }
}
