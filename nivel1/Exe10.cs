using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel1
{
    class Exe10
    {
        static void Main1(string[] args)
        {
            /*Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos
             *  de ordem existentes entre eles. Os relacionamentos possíveis são: Igual, Não igual, 
             *  Maior, Menor, Maior ou igual, Menor ou igual.*/

            int num1, num2;

            Console.WriteLine("Insira o primeiro valor:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numero 1: " + num1 + "   " + "   " + "   " + "   " + "   " + "   " + "Numero 2: " + num2);

            if (num1 == num2)
            {
                Console.WriteLine("Os dois numeros são iguais!");
            }
            else
            {
                Console.WriteLine("Os dois numeros não são iguais!");
            }
            if (num1 > num2)
            {
                Console.WriteLine("O numero 1 é maior que o numero 2");
            }
            else
            {
                Console.WriteLine("O numero 2 é maior que o numero 1");
            }
            if (num1 < num2)
            {
                Console.WriteLine("O numero 1 é menor que o numero 2");
            }
            else
            {
                Console.WriteLine("O numero 2 é menor que o numero 1");
            }
            if (num1 >= num2)
            {
                Console.WriteLine("O numero 1 é maior ou igual ao numero 2");
            }
            else
            {
                Console.WriteLine("O numero 2 é maior ou igual ao numero 1");
            }
            if (num1 <= num2)
            {
                Console.WriteLine("O numero 1 é menor ou igual ao numero 2");
            }
            else
            {
                Console.WriteLine("O numero 2 é menor ou igual ao numero 1");
            }

            Console.ReadKey();



        }
    }
}
