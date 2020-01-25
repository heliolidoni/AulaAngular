using ApiRobustas.Domain.Interface.Arguments;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobustas.Domain.Arguments.Jogador
{
    public class AutenticarJogadorRequest : IRequest
    {
        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
