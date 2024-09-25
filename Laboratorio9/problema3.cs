using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio9
{
    class problema3
    { 
        public void problema_3()
        {

            string[] tipoTriangulo = { "Equilatero", "Isosceles", "Escaleno" };


            byte lado1, lado2, lado3;
            Console.Write("ingrese primer lado del triangulo :");

            lado1 = byte.Parse(Console.ReadLine());
            Console.Write("ingrese segundo lado del triangulo :");
             
            lado2 = byte.Parse(Console.ReadLine());
            Console.Write("ingrese tercer lado del triangulo :");


            lado3 = byte.Parse(Console.ReadLine());

            if(lado1 == lado2 && lado3 == lado1)
            {
                Console.WriteLine("su triangulo es de tipo Equilatero");
            }
            else if(lado1 == lado2 && lado1 != lado3)
            {
                Console.WriteLine("su triangulo es de tipo Isosceles");
            }
            else
            {
                Console.WriteLine("su triangulo es de tipo Escaleno");
            }




        }




    }
}
