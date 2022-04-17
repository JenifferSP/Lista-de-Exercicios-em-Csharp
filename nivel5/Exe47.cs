using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe47
	{
		static void Main1(string[] args)
		{
			/*Considere um vetor positivo de 10 números inteiros maiores que zero e um único número
			* inteiro, também positivo e maior que zero. Faça um programa para:
			*a. ler pelo teclado o vetor;
			*b. ler pelo teclado ou número X;
			*C. dizer quantos números no vetor são maiores que X, menores que X e iguais a X.*/


			int[] vetor = new int[10];
			for (int x = 0; x < 10; x++)
			{
				Console.WriteLine($"Digite {x + 1}° Número do vetor: ");
				vetor[x] = Convert.ToInt32(Console.ReadLine());
			}


			int numX;
			Console.Write("Digite o valor de X: ");
			numX = Convert.ToInt32(Console.ReadLine());

			int maiores = 0, menores = 0, iguais = 0;
			Console.WriteLine($"Número maior que o número X: ");
			for (int i = 0; i < 10; i++)
			{
				if (vetor[i] > numX)
				{
					Console.WriteLine(vetor[i]);
					maiores++;
				}
				else if (vetor[i] == numX)
				{
					iguais++;
				}
				else
				{
					menores++;
				}
			}

			Console.WriteLine($"Menores: {menores}");
			Console.WriteLine($"Maiores: {maiores}");
			Console.WriteLine($"Iguais: {iguais}");

		}
	}
}
