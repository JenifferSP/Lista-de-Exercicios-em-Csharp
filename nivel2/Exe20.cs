using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lista2
{
    class Exe20
    {
        public static void Main1(String[] args)
        {
            /*Escrever um programa declarando três variáveis do tipo inteiro (a, b e c).
             * Ler um valor maior que zero para cada variável (se o valor digitado não é válido,
             * mostrar mensagem e ler novamente). Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo menor.*/
            int a, b, c, multi, divisao;


            Console.WriteLine("Entre com o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Valor invalido! insira novamente: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entre com o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("Valor invalido! insira novamente: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entre com o terceiro valor: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (c < 0)
            {
                Console.WriteLine("Valor invalido! insira novamente: ");
                c = Convert.ToInt32(Console.ReadLine());
            }


            if (a >= b && b >= c)
            {
                multi = c * a;
                divisao = a / c;
                Console.WriteLine($"A multiplicação é: {multi}");
                Console.WriteLine($"A divisão é: {divisao}");
            }
     
            if (a <= b && b <= c)
            {
                multi = a * c;
                divisao = c / a;
                Console.WriteLine($"A multiplicação é: {multi}");
                Console.WriteLine($"A divisão é: {divisao}");
            }

            if (b <= a && a <= c)
            {
                multi = b * c;
                divisao = c / b;
                Console.WriteLine($"A multiplicação é: {multi}");
                Console.WriteLine($"A divisão é: {divisao}");
            }
       
            if (a <= c && c <= b)
            {
                multi = a * b;
                divisao = b / a;
                Console.WriteLine($"A multiplicação é: {multi}");
                Console.WriteLine($"A divisão é: {divisao}");
            }
            
            if (b <= c && c <= a)
            {
                multi = b * a;
                divisao = a / b;
                Console.WriteLine($"A multiplicação é: {multi}");
                Console.WriteLine($"A divisão é: {divisao}");
            }
            
            if (c <= a && a <= b)
            {
                multi = c * b;
                divisao = b / c;
                Console.WriteLine($"A multiplicação é: {multi}");
                Console.WriteLine($"A divisão é: {divisao}");
            }
        }
    }
}