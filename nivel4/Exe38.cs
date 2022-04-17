using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel4
{
	class Exe38
	{
		static void Main1(string[] args)
		{

			/*Faça um programa que leia as variáveis C e N, respectivamente código e
			/// número de horas trabalhadas de um operário. E calcule o salário sabendo-se que
			/// ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o
			/// excesso de pagamento armazenando-o na variável E, caso contrário zerar tal
			/// variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento
			/// imprimir o salário total e o salário excedente. O programa só deve parar de
			/// rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
			/// programa?".*/
			

			int C;
			double N, E = 0, VHora, VExcedente;
			bool continuar = true;
			char texto;

			do
			{
				E = 0;
				VHora = 10;
				VExcedente = VHora * 2;

				Console.WriteLine("Digite o código do operário: ");
				C = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine("Digite o número de horas trabalhadas: ");
				N = Convert.ToSingle(Console.ReadLine());

				if (N > 50)
				{
					E = N - 50;
				}

				Console.WriteLine($"\nID: {C} \nSalario:  {N * VHora}  \nSalario excedente: {E * VExcedente} \nSalario total: {E * VExcedente + N * VHora}");

				Console.WriteLine("Deseja encerrar o programa?(s/n)");
				texto = Convert.ToChar(Console.ReadLine());


				if (texto == 's' || texto == 'S')
				{
					continuar = false;
				}

			} while (continuar);

		}
	}
}

