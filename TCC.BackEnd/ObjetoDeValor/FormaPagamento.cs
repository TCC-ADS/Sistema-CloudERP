using Domain.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Dinheiro; }
        }
        public bool EhCartaoCredito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool EhCartaoDebito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoDebito; }
        }
        public bool NaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

    }
}
