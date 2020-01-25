using ApiRobustas.Domain.Interface.Arguments;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobustas.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome { get; set; }

        public string Email { get; set; }
    }
}
