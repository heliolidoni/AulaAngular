using ApiRobustas.Domain.Arguments.Jogador;
using ApiRobustas.Domain.Services;
using System;

namespace Teste.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando");

            var servico = new ServiceJogador();

            AutenticarJogadorRequest request = new AutenticarJogadorRequest();

            request.Email = "Heliolidoni@hotmail.com";

            var response = servico.AutenticarJogador(request);

            Console.ReadKey();

        }
    }
}
