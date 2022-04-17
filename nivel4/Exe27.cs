using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe27
	{
		static void Main1(string[] args)
		{

			/*Escreva um programa que leia:
			///   - a quantidade de números que deverá processar;
			///   - os números que deverá processar, e calcule e exiba, para cada número a ser
			///     processado o seu fatorial.
			///     Lembrete: O fatorial de um número N é dado pela fórmula:
			///     N! = 1 * 2 * 3 * 4 * 5 * ... * N*/

			int qtd;
			Console.WriteLine("Quantos numeros deseja adicionar?: ");
			qtd = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();

			int[] num = new int[qtd];
			for (int x = 0; x < num.Length; x++)
			{
				Console.Write($"Digite o {x + 1}º número: ");
				num[x] = Convert.ToInt32(Console.ReadLine());
			}
			for (int x = 0; x < num.Length; x++)
			{
				long resultado = 1;
				for (long y = num[x]; y > 0; y--)
				{
					resultado = y * resultado;
				}

				Console.WriteLine($"\nO fatorial de {num[x]} é: {resultado}");
			}

		}
	}
}
