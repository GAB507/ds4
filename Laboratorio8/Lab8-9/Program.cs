﻿using System;

namespace Lab8_9
{

    interface iTemplate
    {
        public void ponerVariable(string nombre, string var);
        public void verHtml(string template);
    }

    class Template : iTemplate
    {
        public void ponerVariable(string nombre , string var)
        {
            Console.WriteLine("Metodo poner variable {nombre} : {var}");
        }

        public void verHtml(string template)
        {
            Console.WriteLine(template);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Template temp1 = new Template();
            temp1.ponerVariable("var1", "Valor 1");
            temp1.ponerVariable("var2", "Valor 2");
            temp1.ponerVariable("var3", "Valor 3");
            temp1.verHtml("<br>Texto de Prueba </br>");


        }
    }
}
