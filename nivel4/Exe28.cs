using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel3
{
    class Exe28
    {
        static void Main1(string[] args)
        {

            /* Faça um programa que gera e escreve os números ímpares dos números lidos entre 100 e 200.*/

            for (int x = 100; x <= 200; x++)
            {
                if (x % 2 == 1)
                {
                    Console.WriteLine(x);
                }
            }

        }
    }
}

