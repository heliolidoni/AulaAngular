using Dominio.Contratos;
using Dominio.Entidades;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(Context context) : base(context)
        {
        }
    }
}
