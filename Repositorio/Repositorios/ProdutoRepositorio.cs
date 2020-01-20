using Dominio.Contratos;
using Dominio.Entidades;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(Context context) : base(context)
        {
        }
    }
}
