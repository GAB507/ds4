using System;

namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problema 1");
            Console.WriteLine("******************************\n");
            problema1();


            Console.WriteLine("Problema 2");
            Console.WriteLine("******************************\n");
            problema2 p2 = new();
            p2.problema_2();


            Console.WriteLine("Problema 3");
            Console.WriteLine("******************************\n");
            problema3 p3 = new();
            p3.problema_3();


            Console.WriteLine("Problema 4");
            Console.WriteLine("******************************\n");
            problema4 p4 = new();
            p4.problema_4();


            Console.WriteLine("Problema 5");
            Console.WriteLine("******************************\n");

            problema5 p5 = new();
            p5.problema_5();


        }


        public static void problema1()
        {
            string nroCuenta = "";
            float producto = 0f;
            do
            {
                Console.Write("introduzca el precio del producto:");
                producto = float.Parse(Console.ReadLine());

                if (producto > 0f)
                {

                    Console.WriteLine("Por favor elija su metodo de pago:  E= Efectivo T = Tarjeta ?");
                    char elegir = Console.ReadLine().ToCharArray()[0];

                    if (elegir.ToString().ToUpper() == "T")
                    {
                        Console.WriteLine("Digite numero de cuenta:");
                        nroCuenta = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("\nIntroduzca por favor un valor mayor a 0...");
                }
            } while (producto <= 0f);
        }


    }

}
