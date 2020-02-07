﻿using System.Collections.Generic;
using System.Linq;

namespace Domain.Entidades
{
    public abstract class Entidade 
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }
        protected void LimparMensagens()
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return (!mensagemValidacao.Any()); }
        }
    }
}
