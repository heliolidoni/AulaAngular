using ApiRobustas.Domain.Interface.Arguments;
using ApiRobustas.Domain.ValueObjects;

namespace ApiRobustas.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }
    }
}
