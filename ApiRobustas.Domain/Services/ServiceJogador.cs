using ApiRobustas.Domain.Arguments.Jogador;
using ApiRobustas.Domain.Interface.Repositories;
using ApiRobustas.Domain.Interface.Services;
using System;

namespace ApiRobustas.Domain.Services
{
    public class ServiceJogador : IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            this._repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Guid id = _repositoryJogador.AdicionarJogador(request).Id;

            return new AdicionarJogadorResponse() { Id = id, Message = "Adicionado com sucesso!"};

        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("Errow AutenticarJogador");
            }

            if(String.IsNullOrEmpty(request.Email))
            {

            }

            if (IsEmail(request.Email))
            {

            }

            if (String.IsNullOrEmpty(request.Senha))
            {

            }

            return _repositoryJogador.AutenticarJogador(request);
        }

        private bool IsEmail(string email)
        {
            return true;
        }
    }
}
