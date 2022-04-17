
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe18
    {
        static void Main1(string[] args)
        {
            /*Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código é igual a 1, igual a 2 ou igual a 3.
             * Caso não seja, apresentar a mensagem “Código inválido”. Ao ser verificado o código e constatado que é um valor válido, 
             * o programa deve verificar cada código em separado para determinar seu valor por extenso, ou seja, apresentar a mensagem “um”, 
             * ”dois” ou “três”. (Utilizar o comando Switch). .*/
            int codigo;

            Console.WriteLine("Insira um valor: ");
            codigo = Convert.ToInt16(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Codigo valido!: " + codigo + " 'Um'");
                    break;
                case 2:
                    Console.WriteLine("Codigo valido! " + codigo + " 'Dois'");
                    break;
                case 3:
                    Console.WriteLine("Codigo valido! " + codigo + " 'Tres'");
                    break;
                default:
                    Console.WriteLine("Codigo invalido! " + codigo);
                    break;

            }



        }
    }
}

