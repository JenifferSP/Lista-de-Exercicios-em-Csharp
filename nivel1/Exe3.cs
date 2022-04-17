using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nivel1
{
    class Exe3
    {
        static void Main1(string[] args)
        {
            /*Faça um programa para pagamento de comissão de vendedores de peças,
              *  levando-se em consideração que sua comissão será de 5% do total da venda 
              *  e que você tem os seguintes dados: 
              *  -Identificação do vendedor 
              *  -Código da peça 
              *  -Preço unitário da peça 
              *  -Quantidade vendida */

            string vendedor;
            int cod, qtd;
            double commit, preco, venda;

            //identificação 
            Console.WriteLine("Bem vindo! insira seu nome completo:");
            vendedor = Console.ReadLine();

            Console.WriteLine("Insira o codigo do produto:");
            cod = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o preço unitario:");
            preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade vendida:");
            qtd = Convert.ToInt32(Console.ReadLine());

            //Calculo da venda
            venda = qtd * preco;
            commit = venda * 0.05;

            //resultado da venda
            Console.WriteLine($"Vendedor:" + vendedor);
            Console.WriteLine($"Cod.Produto:" + cod);
            Console.WriteLine($"Preço:" + preco);
            Console.WriteLine($"Qtd.Vendida:" + qtd);
            Console.WriteLine($"Total:" + venda);
            Console.WriteLine($"Comissão:" + commit);

            Console.ReadKey();


        }
    }
}
