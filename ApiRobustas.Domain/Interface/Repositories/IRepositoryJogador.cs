using ApiRobustas.Domain.Arguments.Jogador;
using ApiRobustas.Domain.Entities;
using System;

namespace ApiRobustas.Domain.Interface.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        Guid AdicionarJogador(Jogador jogador);
    }
}
