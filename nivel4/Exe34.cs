using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe34
	{
		static void Main1(string[] args)
		{

			/*Escreva um programa que leia um conjunto de números positivos e exiba o
			/// menor e o maior. Suporemos que o número de elementos deste conjunto não é
			/// conhecido, e que um número negativo será utilizado para sinalizar o fim dos
			/// dados.*/

			int num, maior, menor;
		

			Console.WriteLine("Digite um número posiivo: ");
			num = Convert.ToInt32(Console.ReadLine());

			if (num >= 0)
			{
				menor = num;
				maior = num;
				while (num >= 0)
				{
					Console.WriteLine("Digite outro número: ");
					num = Convert.ToInt32(Console.ReadLine());
					if (num > maior)
					{
						maior = num;
					}
					if (num < menor && num >= 0)
					{
						menor = num;
					}
				}
				Console.WriteLine($"O maior número foi {maior} e o menor foi {menor}");
			}
			Console.ReadKey();

		}
	}
}

