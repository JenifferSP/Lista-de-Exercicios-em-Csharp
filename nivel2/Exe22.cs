
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe22
    {
        static void Main1(string[] args)
        {

            /*Faça um programa que leia um número. Se positivo armazene-o em A, se for negativo, em B. No final mostrar o resultado. */

            int num, A = 0, B = 0;

            Console.WriteLine("Informe um valor: ");
            num = Convert.ToInt32(Console.ReadLine());



            if (num > 0)
            {
                A = num;
            }
            else
            {
                B = num;
            }
            Console.WriteLine("O valor de A (positivo): " + A);
            Console.WriteLine("O valor de B (negativo): " + B);

        }
    }
}


