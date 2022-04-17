
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel3
{
    class Exe25
    {
        static void Main1(string[] args)
        {

            /*Tendo como dados de entrada a altura e o sexo de uma pessoa,
             * faça um programa que calcule seu peso ideal, utilizando as seguintes fórmulas:
             * (h = altura)
             * -Para homens: (72.7*h) - 58 
             * -Para mulheres: (62.1 *h) - 44.7 */

            string sexo;
            double altura;
            double peso = 00.0;

            Console.WriteLine("Insira seu sexo: ");
            Console.WriteLine("Onde 'F' é femnino // e 'M' masculino");
            sexo = Console.ReadLine();

            Console.WriteLine("Utilize ',' exemplo: 1,80");
            Console.WriteLine();
            Console.WriteLine("Insira sua altura: ");
            altura = Convert.ToSingle(Console.ReadLine());

            if (sexo == "F")
            {
                peso = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é: { string.Format("{0:C2}", (peso))}");
            }
            if (sexo == "M")
            {
                peso = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é: { string.Format("{0:C2}", (peso))}");
            }

        }
    }
}


