using Dominio.Entidades;

namespace Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario ObterPorEmail(string email, string senha);
    }
}
