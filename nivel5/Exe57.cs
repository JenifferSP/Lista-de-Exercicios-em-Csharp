using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe57
	{
		static void Main1(string[] args)
		{

			/*  Fazer um programa que leia uma frase e imprima somente as vogais.*/


			string frase, Vogais = "aeiouAEIOU", StringVogais = "";

			Console.Write("Digite uma frase: ");
			frase = Console.ReadLine();

			char[] ArrayChars = frase.ToCharArray();

			for (int x = 0; x < ArrayChars.Length; x++)
			{


				if (Vogais.Contains("" + ArrayChars[x]))
				{ 
					StringVogais += ArrayChars[x];
				}
			}

			Console.WriteLine("Nova frase: " + StringVogais);


		}
	}
}
