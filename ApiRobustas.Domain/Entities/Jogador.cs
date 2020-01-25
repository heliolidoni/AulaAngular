using ApiRobustas.Domain.Enum;
using ApiRobustas.Domain.ValueObjects;
using System;

namespace ApiRobustas.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }

        public EnumSituacaoJogador Status { get; set; }

    }
}
