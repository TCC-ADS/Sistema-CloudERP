using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Funcionario : Entidade
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public string Longradouro { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int Telefone { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
