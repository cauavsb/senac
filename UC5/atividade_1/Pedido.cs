using System;
using System.Collections.Generic;
namespace atividade_1
{
    public class Pedido
    {
        private List<ItemPedido> listaProdutos;

        public Pedido() {
            listaProdutos = new List<ItemPedido>();
        }

        public void incluir(ItemPedido item) {
            listaProdutos.Add(item);
        }

        public double totalizar() {
            double total = 0;
            foreach(ItemPedido item in listaProdutos) {
                double p = item.valor_unitario * item.quantidade;
                total += p;
            }
            return total;
        }
    }
}