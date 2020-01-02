using Domain.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get { return Cod == (int)TipoFormaPagamentoEnum.Dinheiro; }
        }
        public bool EhCartaoCredito
        {
            get { return Cod == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool EhCartaoDebito
        {
            get { return Cod == (int)TipoFormaPagamentoEnum.CartaoDebito; }
        }
        public bool NaoFoiDefinido
        {
            get { return Cod == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

    }
}
