using System.Collections.Generic;
using System.Linq;

namespace Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> MensagemValidacao
        {  
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarMensagemValidacao(string msg)
        {
            MensagemValidacao.Add(msg);
        }

        public abstract void Validate();
        public bool EhValido { get { return !MensagemValidacao.Any(); } }
    }
}
