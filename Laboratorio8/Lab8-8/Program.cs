﻿using System;

namespace Lab8_8
{

    abstract class ClaseAbstracta
    {

        abstract protected string tomarValor();
        abstract public string prefixValor(string prefix);

        public void printOut()
        {
            Console.WriteLine(tomarValor());
        }

    }

    class ClaseConcretal : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClaseConcretal";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcretal";
        }
         
    }

    class ClaseConcreta2: ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClaseConcretal2";
        }

        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcreta2";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            ClaseConcretal concreta1 = new ClaseConcretal();
            concreta1.printOut();
            Console.WriteLine(concreta1.prefixValor("es_"));

            ClaseConcretal concreta2 = new ClaseConcretal();
            concreta2.printOut();
            Console.WriteLine(concreta2.prefixValor("es_"));


        }
    }
}
