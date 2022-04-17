using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe32
	{
		static void Main1(string[] args)
		{

			/*Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros
			/// números inteiros positivos ímpares a partir do número informado pelo usuário menor que 10
			/// e maior que zero.*/

			int Num, Result = 0;

			do
			{
				Console.Write("Digite um número maior que 0 e menor que 10: ");
				Num = Convert.ToInt32(Console.ReadLine());
			} while (Num <= 0 || Num >= 10);

			for (int x = Num; x < 40 + Num; x++)
			{
				if (x % 2 == 1)
				{
					Result += x * x;
				}
			}
			Console.WriteLine($"O resultado da soma do numero informado é: {Result}");


		}
	}
}

