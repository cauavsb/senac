using System;
using System.Collections.Generic;
namespace atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();

            do{
                Console.Write("Digite a descrição do produto: ");
                string descricao = Console.ReadLine();

                Console.Write("Digite o valor unitário do produto: ");
                double valor_unitario = double.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());

                ItemPedido item = new ItemPedido();
                item.descricao = descricao;
                item.valor_unitario = valor_unitario;
                item.quantidade = quantidade;

                pedido.incluir(item);

                Console.Write("Deseja incluir outro item no pedido? (S/N) ");
            } 
            
            while (Console.ReadLine().ToUpper() == "S");

            Console.WriteLine("Total do pedido: R$ " + pedido.totalizar().ToString("F2"));
        }
    }
}