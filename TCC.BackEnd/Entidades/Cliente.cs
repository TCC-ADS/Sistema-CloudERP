using Domain.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Cliente : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Longradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int Telefone { get; set; }
        //Usuario faz 1 ou muitos pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
