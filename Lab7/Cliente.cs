using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Cliente
    {
        private string nombre;
        private int monto;

        public Cliente(string nom)
        {
            this.nombre = nom;
            this.monto = 0;
        }

        public void Depositar(int m)
        {
            this.monto += m;
        }

        public void Extraer(int m)
        {
            this.monto -= m;
        }

        public int RetornarMonto() => this.monto;

        public void Imprimir() => Console.WriteLine($"{this.nombre} tiene depositado la suma de {this.monto}");

    }
}
