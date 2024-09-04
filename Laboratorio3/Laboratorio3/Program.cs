using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            goto program31;
            int primerNumero, segundoNumero, suma;

            Console.WriteLine("Introduce el primer numero: ");
            primerNumero = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Introduce el segundo numero: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());

            suma = primerNumero + segundoNumero;
            Console.WriteLine("La suma de {0} y {1} es {2}",primerNumero,segundoNumero,suma);

            program31:;
           



        }
    }
}
