using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe55
	{
		static void Main1(string[] args)
		{

			/* Fazer um programa que leia uma frase de até 50 caracteres e imprima a
			* frase sem os espaços em branco.
			* Imprimir também a quantidade de espaços em branco da frase.*/


			string frase;
			string NovaFrase = "";

			do
			{
				Console.Write("Digite uma frase (limite de 50 caracteres): ");
				frase = Console.ReadLine();

			} while (frase.Length > 50);

			char[] ArrayChars = frase.ToCharArray();

			for (int x = 0; x < ArrayChars.Length; x++)
			{
				if (ArrayChars[x] != ' ')
				{
					NovaFrase = NovaFrase + ArrayChars[x];
				}
			}
			Console.WriteLine($"Nova frase: {NovaFrase}");

		}
	}
}
