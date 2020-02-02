using ApiRobustas.Domain.Interface.Arguments;

namespace ApiRobustas.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse : IResponse
    {
        public string PrimeiroNome { get; set; }

        public string Email { get; set; }
    }
}
