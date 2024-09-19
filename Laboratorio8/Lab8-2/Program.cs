﻿using System;

namespace Lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {

            const string CUENTA = "100";

            Cuenta cuenta = new Cuenta(CUENTA);
            CuentaCorriente cuentaCorriente = new CuentaCorriente(CUENTA);
            CuentaAhorro cuentaAhorro = new CuentaAhorro(CUENTA);

            cuenta.CalcularIntereses();
            cuentaCorriente.CalcularIntereses();
            cuentaAhorro.CalcularIntereses();



        }
    }


    public class Cuenta
    {
        private string idCuenta;

        public Cuenta(string prmtIdCuenta)
        {
            this.idCuenta = prmtIdCuenta;
            Console.WriteLine(
            "Constructor Clase Base para cuenta {0}",prmtIdCuenta);
        }

        public virtual void CalcularIntereses()
        {
            Console.WriteLine(
            "Cuenta.CalcularIntereses() efectuado para la cuenta {0}",
            this.idCuenta);
        }

        public string getIdCuenta() {

            return this.idCuenta;
        }
         
    }

    public class CuentaCorriente: Cuenta
    {

        public CuentaCorriente(string prmtIdCuenta):base(prmtIdCuenta)
        {

        }

        public override void CalcularIntereses()
        {
            Console.WriteLine(
            "CuentaCorriente.CalcularIntereses() efectuado para la cuenta {0}",
            this.getIdCuenta());
        }
         
    }

    public class CuentaAhorro:Cuenta
    {

        public CuentaAhorro(string prmtIdCuenta):base(prmtIdCuenta)
        {

        }

        public override void CalcularIntereses()
        {
            Console.WriteLine(
             "CuentaCorriente.CalcularIntereses() efectuado para la cuenta {0}",
             this.getIdCuenta());
        }

    }

}
