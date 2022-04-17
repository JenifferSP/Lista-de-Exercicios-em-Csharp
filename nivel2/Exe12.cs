
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe12
    {
        static void Main1(string[] args)
        {
            /*Escreva um programa que leia um número inteiro e exiba o seu módulo. 
             * O módulo de um número x é: x se x é maior ou igual a zero x 
             * * (-1) se x 
             * é menor que zero.*/

            int numX, modulo;

            Console.WriteLine("Inrira um valor para X: ");
            numX = Convert.ToInt16(Console.ReadLine());

            if (numX >= 0)
            {
                modulo = numX * (-1);
            }
            else
            {
                modulo = numX;
                Console.WriteLine("X é menor que zero: " + modulo);
            }
            Console.WriteLine("O modulo de X é: " + modulo);
            Console.ReadKey();


        }
    }
}
