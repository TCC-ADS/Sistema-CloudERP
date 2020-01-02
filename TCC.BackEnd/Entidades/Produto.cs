using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Produto :Entidade
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal preco { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
