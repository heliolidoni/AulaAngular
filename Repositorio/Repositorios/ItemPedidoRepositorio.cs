using Dominio.Contratos;
using Dominio.Entidades;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class ItemPedidoRepositorio : BaseRepositorio<ItemPedido>, IItemPedidoRepositorio
    {
        public ItemPedidoRepositorio(Context context) : base(context)
        {
        }
    }
}
