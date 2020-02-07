using Domain.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public int FuncionarioId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public int FormaPagamentoId { get; set; }


        //Pedido deve ter 1 ou mais pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagens();

            if (!ItensPedido.Any())
                AdicionarCritica("Pedido não pode ficar sem item de pedido");
            
            if (FormaPagamentoId == 0)
            {
                AdicionarCritica("Critica - Não foi informado a forma de pagamento");
            }
        }
    }
}
