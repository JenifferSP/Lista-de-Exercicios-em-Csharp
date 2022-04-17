using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe58
	{
		static void Main1(string[] args)
		{

			/*Fazer um programa para vários números inteiros em um vetor e
			* positiva e calcular a média. Imprimir também o maior. A quantidade de números
			* lidos será definido pelo usuário.*/


            int qtd = 0;
			double media = 0;

			Console.WriteLine("Digite a quantidade de números: ");
			qtd = Convert.ToInt32(Console.ReadLine());

			int[] numeros = new int[qtd];
			for (int x = 0; x < qtd; x++)
			{
				Console.Write($"Digite o valor {x + 1}: ");
				numeros[x] = Convert.ToInt32(Console.ReadLine());
				media += numeros[x];
			}
			media = media / qtd;
			Array.Sort(numeros);

			Console.WriteLine($"A média dos valores é: {media} \nO maior valor é: {numeros[qtd - 1]}");

		}
	}
}
