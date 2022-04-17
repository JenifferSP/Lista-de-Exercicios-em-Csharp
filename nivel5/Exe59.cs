﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe59
	{
		static void Main1(string[] args)
		{

			/* Escreva um programa que solicite dois caracteres de A a Z ao usuário e
			* imprima o número de caracteres existentes entre eles. Assuma que o usuário
			* digite os 2 caracteres em ordem alfabética. Caso não o avaliar, emitir
			* mensagem de erro.
			* Exemplo: Digite 2 caracteres: jt O numero de caracteres entre eles é: 9*/


			char[] letras = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'w', 'y', 'z' };

			Console.WriteLine("Digite a primeira letra: ");
			char caractere = Convert.ToChar(Console.ReadLine());

			int primeiraL = ContaLetra(caractere, letras);

			Console.WriteLine("Digite a segunda letra: ");
			char outroL = Convert.ToChar(Console.ReadLine());

			int segundoL = ContaLetra(outroL, letras);


			int diferencas = segundoL - primeiraL - 1;

			if (primeiraL >= 0 && segundoL >= 0 && diferencas >= 0)
			{
				Console.WriteLine($"O numero de caracteres entre eles é: {diferencas}");
			}
			else
			{
				Console.WriteLine("Erro!");
			}
		}

		public static int ContaLetra(char ch, char[] letras)
		{

			int num = -1;
			for (int x = 0; x < letras.Length; x++)
			{
				if (letras[x] == ch)
				{
					num = x;
				}
			}
			return num;
		}
	}
}




