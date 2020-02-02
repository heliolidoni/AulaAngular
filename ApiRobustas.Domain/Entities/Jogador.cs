using ApiRobustas.Domain.Enum;
using ApiRobustas.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;

namespace ApiRobustas.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNotEmail(e => e.Email.EnderecoEmail, "E-mail Invalido")
                .IfNullOrInvalidLength(s => s.Senha, 6, 32, "Senha Invalida");
        }

        public Guid Id { get; set; }

        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }

        public EnumSituacaoJogador Status { get; set; }

    }
}
