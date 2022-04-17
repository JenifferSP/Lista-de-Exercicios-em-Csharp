using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe44
	{
		static void Main1(string[] args)
		{

			/*Faça um programa que exiba as opções:
			/// 	1 – Conversão de Graus Celsius em Graus Fahrenheit
			/// 	2 – Conversão de Graus Fahrenheit em Graus Celsius
			/// 	3 – Peso ideal do homem
			/// 	4 – Peso ideal da mulher
			/// O programa só deve encerrar quando o usuário digitar  ́S ́ para a pergunta
			///  "Deseja encerrar o programa?”
			/// Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.*/

			bool continuar = true;
			char letra;
			int opcao;

			do
			{
				do
				{
					Console.WriteLine("Escolha uma dad opção a baixo: ");
					Console.WriteLine("1 – Conversão de Graus Celsius em Graus Fahrenheit");
					Console.WriteLine("2 – Conversão de Graus Fahrenheit em Graus Celsius");
					Console.WriteLine("3 – Peso ideal do homem");
					Console.WriteLine("4 - Peso ideal da mulher");
					opcao = Convert.ToInt32(Console.ReadLine());
					if (opcao < 1 || opcao > 4)
					{
						Console.WriteLine("Opção Errada!");
					}
				} while (opcao < 1 || opcao > 4);

				double Celsius, Fahrenheit;
				double Altura, PesoIdeal;

				switch (opcao)
				{
					case 1:
						Console.WriteLine("Digite a temperatura em °C: ");
						Celsius = Convert.ToDouble(Console.ReadLine());
						Fahrenheit = (Celsius * 1.8) + 32;
						Console.WriteLine($"A temperatura convertida é: {Fahrenheit} °F");
						break;

					case 2:
						Console.WriteLine("Digite a temperatura em °F: ");
						Fahrenheit = Convert.ToDouble(Console.ReadLine());
						Celsius = (Fahrenheit - 32) / 1.8;
						Console.WriteLine($"A temperatura convertida é: {Celsius} °C");
						break;

					case 3:
						Console.WriteLine("Digite a sua altura: ");
						Altura = Convert.ToDouble(Console.ReadLine());
						PesoIdeal = (72.7 * Altura) - 58;
						Console.WriteLine($"Seu peso ideal é: {PesoIdeal} Kg");
						break;

					case 4:
						Console.WriteLine("Digite a sua altura: ");
						Altura = Convert.ToDouble(Console.ReadLine());
						PesoIdeal = (62.1 * Altura) - 44.7;
						Console.WriteLine($"Seu peso ideal é: {PesoIdeal} Kg");
						break;

					default:
						Console.WriteLine("Opção Invalida!!");
						break;
				}

				Console.WriteLine("\nDeseja encerrar o programa? (s/n) ");
				letra = Convert.ToChar(Console.ReadLine());

				if (letra == 's' || letra == 'S')
				{
					continuar = false;
				}
			} while (continuar);

		}
	}
}

