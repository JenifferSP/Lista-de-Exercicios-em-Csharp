using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel5
{
	class Exe50
	{
		static void Main1(string[] args)
		{
			/*Fazer um programa que sorteie um número de 0 a 100 e que permita que o
			* usuário (sem o número sorteado) tente conhecer. Caso não certo, o
			* programa deve imprimir uma mensagem informando se o número sorteado é maior ou
			* menor que a tentativa feita. Ao corrigir o número, ou programa deve imprimir a
			* quantidade de tentativas feitas.*/


			Random gerador = new Random();
			bool acertou = false;
			int chute, QTDtentativas = 0;

			int numero = gerador.Next(101);

			while (acertou == false)
			{
				Console.Write("Digite um número entre 0 a 100: ");
				chute = Convert.ToInt32(Console.ReadLine());
				QTDtentativas++;
				if (chute == numero)
				{
					Console.WriteLine($"Você acertou em {QTDtentativas}  tentativas!");
					acertou = true;
				}
				else if (chute > numero)
				{
					Console.WriteLine("O número é menor.");
				}
				else
				{
					Console.WriteLine("O número é maior.");
				}
			}


		}
	}
}
