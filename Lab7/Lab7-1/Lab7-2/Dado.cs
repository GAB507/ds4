using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Dado
    {
        private int valor;
        private static Random aleatorio;

        public Dado()
        {
            aleatorio = new Random();
        }

        public void Tirar()
        {
            this.valor = aleatorio.Next(1, 7);
        }

        public void Imprimir()
        {
            Console.WriteLine("El valor del dado es:"+this.valor);
        }

        public int RetornarValor() => this.valor;

    }
}
