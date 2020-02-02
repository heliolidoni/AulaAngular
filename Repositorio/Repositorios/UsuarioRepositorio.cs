using Dominio.Contratos;
using Dominio.Entidades;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(Context context) : base(context)
        {
        }

        public Usuario ObterPorEmail(string email, string senha)
        {
            return Context.Usuario.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
