using ApiRobustas.Domain.Arguments.Plataforma;

namespace ApiRobustas.Domain.Interface.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarPlataformaRequest);
    }
}
