
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe17
    {
        static void Main1(string[] args)
        {
            /*Escreva um programa que leia um número inteiro. Verificar por meio de condição se o valor fornecido está 
             * na faixa entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da faixa, apresentar a mensagem 
             * “valor válido”. Caso contrário, apresentar a mensagem “valor inválido”.*/

            int num1;

            Console.WriteLine("Insira um valor");
            num1 = Convert.ToInt16(Console.ReadLine());

            if (num1 >= 0 && num1 <= 9)
            {
                Console.WriteLine("Valor Valido!");
            }
            else
            {
                Console.WriteLine("Valor Invalido!");
            }


        }
    }
}

