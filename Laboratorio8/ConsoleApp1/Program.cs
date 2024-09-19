using System;

namespace Lab8_4
{
    // propiedades con validaciones

    public class CuentaBancaria
    {
        private decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0)
                {
                    saldo = value;
                }
                else
                    throw new ArgumentException("El saldo no puede ser negativo");
            }

        }


    }

    public class Empleado
    {
        private string nombre;
         
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

    }

    // propiedades de solo lectura

    public class Cobertura
    {

        private double radio;

        public Cobertura(double _radio)
        {
            radio = _radio;
        }

        public double Radio
        {
            get { return radio; }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Jhon Doe";

            Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");

            CuentaBancaria cta = new CuentaBancaria();
            cta.Saldo = 100;
            Console.WriteLine($"El saldo del empleado: {empleado.Nombre}");

            Cobertura c = new Cobertura(5);
            Console.WriteLine($"Con una cobertura de: {c.Radio}");

        }
    }
}
