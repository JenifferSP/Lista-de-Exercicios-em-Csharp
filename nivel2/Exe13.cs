
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    class Exe13
    {
        static void Main1(string[] args)
        {
            /*
           Escreva um programa que leia 3 numeros inteiros e imprima na tela os valores em ordem decrescente*/

            int num1, num2, num3;

            Console.WriteLine("Digite o 1° valor: ");
            num1 = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Digite o 2° valor: ");
            num2 = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Digite o 3° valor: ");
            num3 = Convert.ToInt16(Console.ReadLine());

            if (num1 > num3)
            {
                int aux = num3;
                num3 = num1;
                num1 = aux;
            }
            if (num1 > num2)
            {
                int aux = num2;
                num2 = num1;
                num1 = aux;
            }
            if (num2 > num3)
            {
                int aux = num3;
                num3 = num2;
                num2 = aux;
            }

            Console.WriteLine("Os numeros insiridos são: " + num1 + ", " + num2 + ", " + num3);
            Console.ReadKey();
        }
    }
}
