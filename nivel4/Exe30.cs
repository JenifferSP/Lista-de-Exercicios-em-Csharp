using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
    class Exe30
    {
        static void Main1(string[] args)
        {

            /* Faça um programa para imprimir uma tabuada.*/

         
        
            for (int x = 1; x <= 10; x++)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($" {x} x {i} = {x*i}");
                   
                }
                    Console.WriteLine();
            }


        }
    }
}

