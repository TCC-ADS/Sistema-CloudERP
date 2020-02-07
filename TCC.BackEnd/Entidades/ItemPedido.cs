using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Qntd { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
            {
                AdicionarCritica("Não foi identificado qual a referencia do produto");
            }

            if (Qntd == 0)
            {
                AdicionarCritica("Quantidade não foi informada");
            }
        }
    }
}
