using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Cod { get; set; }
        public int ProdutoCod { get; set; }
        public int Qntd { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
