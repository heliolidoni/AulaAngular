using ApiRobustas.Domain.Arguments.Jogador;
using ApiRobustas.Domain.Entities;
using ApiRobustas.Domain.Interface.Repositories;
using ApiRobustas.Domain.Interface.Services;
using ApiRobustas.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;

namespace ApiRobustas.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {
        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            this._repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Jogador _jogador = new Jogador(request.Email, request.Senha);

            _jogador.Nome = request.Nome;
            _jogador.Status = Enum.EnumSituacaoJogador.EmAndamento;

            Guid id = _repositoryJogador.AdicionarJogador(_jogador);

            return new AdicionarJogadorResponse() { Id = id, Message = "Adicionado com sucesso!"};
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                throw new Exception("Errow AutenticarJogador");
            }

            var _email = new Email(request.Email);
            var _jogador = new Jogador(_email, request.Senha);

            AddNotifications(_jogador);

            if (_jogador.IsInvalid())
            {
                return null;
            }

            return _repositoryJogador.AutenticarJogador(request);
        }
    }
}
