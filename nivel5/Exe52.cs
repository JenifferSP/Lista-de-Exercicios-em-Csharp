﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe52
	{
		static void Main1(string[] args)
		{
			/*Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas
			* vezes aparece o número 1, 3 e 4, nesta ordem. O vetor terá no máximo 100
			* posições. Sair do programa quando for digitado -1.*/



			int NumPosicoes = 100, x = 0; 
			int[] num = new int[NumPosicoes];
			int Vnum1 = 0, Vnum3 = 0, Vnum4 = 0, aux=1;

			Console.WriteLine("//Digite -1 para encerrar!!//");
			Console.WriteLine();
			Console.WriteLine();
			do
			{
				Console.WriteLine($"Digite o {aux++}º numero: ");
				num[x] = Convert.ToInt32(Console.ReadLine());
				if (num[x] == 1)
				{
					Vnum1++;
				}
				if (num[x] == 3)
				{
					Vnum3++;
				}
				if (num[x] == 4)
				{
					Vnum4++;
				}
				x++;
			} while (num[x - 1] != -1 && x < NumPosicoes);

			Console.WriteLine($"Quantidades:\nNumero 1 = {Vnum1} \nNumero 3 = {Vnum3}  \nNumero 4 = {Vnum4}");

		}
	}
}
