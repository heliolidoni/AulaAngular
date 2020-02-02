using ApiRobustas.Domain.Interface.Arguments;
using System;

namespace ApiRobustas.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}
