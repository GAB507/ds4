using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_2
{
    class Program
    {
        // definicion de metodo que suma dos numeros e imprime el resultado
        public void Sumar(int valor1 , int valor2)
        {
            int variableLocal = valor1 + valor2; //declarando variable local variableLocal
            Console.WriteLine(variableLocal);
        }

        static void Main(string[] args)
        {
            //EJEMPLO 1
            Client client = new Client();
            client.FirstName = "su nombre";
            client.LastName = "su apellido";
            client.Age = 15;
            client.Id = 1;


            //EJEMPLO 2
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);

            //PARTE 3   TIPOS DE DATOS DEL LENGUAJE C#
            String nombre = "Juan Carlos";
            int nombreVariable = 1000;

            // TIPOS DE DATOS VALOR
            int valor1 = 28; //declaramos variable valor1 con un valor de 28
            int valor2 = valor1;
            valor2 = 30;

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);


            //TIPOS DE DATOS POR REFERENCIA

            MyClass object1 = new MyClass();
            object1.nombre = "Fulano"  // -> "da ERROR"
            object1.Edad = 28; // DA ERROR
            MyClass object2 = object1;

            //creando nueva instancia

            MyClass object


        }


        public class Client
        {
            //Declarando variables de instancia en clase.
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public ushort Age { get; set; }

            public string GetFullName()
            {
                return FirstName +" "+ LastName;
            } 

        }

        public class MyClass
        {
            public static int Valor;
        }
    }
}
