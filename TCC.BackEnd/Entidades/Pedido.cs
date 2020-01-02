using Domain.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entidades
{
    public class Pedido
    {
        public int Cod { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioCod { get; set; }
        public int FuncionarioCod { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public int FormaPagamentoId { get; set; }


        //Pedido deve ter 1 ou mais pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
