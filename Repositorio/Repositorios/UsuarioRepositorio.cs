using Dominio.Contratos;
using Dominio.Entidades;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(Context context) : base(context)
        {
        }
    }
}
