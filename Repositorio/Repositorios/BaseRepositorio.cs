using Dominio.Contratos;
using Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly Context Context;
        
        public BaseRepositorio(Context context)
        {
            Context = context;
        }

        public void Adicionar(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            Context.Set<TEntity>().Update(entity);
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public TEntity ObterPorId(int Id)
        {
            return Context.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            Context.Remove(entity);
            Context.SaveChanges();
        }
    }
}
