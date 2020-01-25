using ApiRobustas.Domain.Interface.Arguments;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRobustas.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
