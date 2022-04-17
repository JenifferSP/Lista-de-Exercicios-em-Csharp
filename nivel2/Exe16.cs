
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe16
    {
        static void Main1(string[] args)
        {
            /*Escreva um programa que leia dois números e exiba mensagem informando o valor do maior número e o valor do menor número.
                    Se os dois números forem iguais, o programa deve exibir mensagem informando este fato.*/

            float num1, num2;

            Console.WriteLine("Insira o 1° valor");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o 2° valor");
            num2 = Convert.ToSingle(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O valor do 1° numero " + num1 + " é maior que o valor do 2° numero: " + num2);
            }
            if (num1 < num2)
            {
                Console.WriteLine("O valor do 2° numero " + num2 + " é maior que o valor do 1° numero: " + num1);
            }
            if (num1 == num2)
            {
                Console.WriteLine("O valor do 1° numero: " + num1 + " e o valor do 2° numero: " + num2 + " são iguais!!");
            }

        }
    }
}

