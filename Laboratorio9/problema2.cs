using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio9
{
    class problema2
    {

        public void problema_2()
        {
            byte numero = 1;
            Console.WriteLine("Numeros divisibles entre 3");
            while (numero < 101)
            {
                if(numero%3 == 0)
                {
                    Console.WriteLine(numero);
                }

                numero++;

            }
        }


    }
}
