using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
    class Exe31
    {
        static void Main1(string[] args)
        {

			/* Escrever um programa que leia um conjunto de números positivos, e exiba se o número
             lido é par ou ímpar. Exiba ao final a soma total dos números pares lidos e também a soma dos
             números ímpares lidos. Suporemos que o número de elementos deste conjunto não é
             conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados.*/



			int Numero = 0, Par = 0, Impar = 0, reultPar = 0, reultImpar = 0;

			while (Numero >= 0)
			{

				Console.Write("Digite um número (numeros negativos finalizam): ");
				Numero = Convert.ToInt32(Console.ReadLine());
				if (Numero >= 0)
				{
					if (Numero % 2 == 0)
					{
						Par++;
						reultPar += Numero;
					}
					else
					{
						Impar++;
						reultImpar += Numero;
					}
				}
			}

			Console.WriteLine($"Quantidade de Números Pares: {Par}  Quantidade de Números Impares: {Impar}");
			Console.WriteLine($"A soma dos Pares: {reultPar} A soma dos Impares: {reultImpar}");


		}
    }
}

