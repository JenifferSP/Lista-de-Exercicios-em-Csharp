using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel1
{
    class Exe2
    {
        static void Main1(string[] args)
        {
            /*Faça um programa que: - Leia a cotação do dólar - Leia um valor em dólares - Converta esse valor para Real - Mostre o resultado*/
            double dolar;
            double cotacao;

            Console.WriteLine("Digite a cotação do dolar:");
            cotacao = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite um valor em US$:");
            dolar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor em dolar para real é: {string.Format("{0:C2}", (cotacao * dolar))}");

            Console.ReadKey();

        }
    }
}
