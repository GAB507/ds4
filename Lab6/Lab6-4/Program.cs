using System;

namespace Lab6_4
{
    class Program
    {
        static void chechAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Acceso denegado, no cumple con el criterio de edad");
            }
            else
            {
                Console.WriteLine("Acceso concedido");
            }


        }

        static void Main(string[] args)
        {
            chechAge(15); 
        }
    }
}
