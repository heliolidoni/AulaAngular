using ApiRobustas.Domain.Arguments.Jogador;

namespace ApiRobustas.Domain.Interface.Repositories
{
    public interface IRepositoryJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
    }
}
