using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SGAL.Repositorio.Logic
{
    public abstract class BaseRepository<T> where T : class
    {
        public interface IBaseRepository
        {
            void Incluir(T entity);
            void Alterar(T entity);
            void Excluir(T entity);
            void Excluir(Expression<Func<T, bool>> where);
            T Obter(long id);
            T Obter(string id);
            T ObterPrimeiro(Expression<Func<T, bool>> where);
            IQueryable<T> ObterTodos();
            IQueryable<T> ObterVarios(Expression<Func<T, bool>> where);
            void Salvar();
        }

        private SGEEntities Conexao;
        private readonly IDbSet<T> Contexto;

        protected BaseRepository()
        {
            if (Conexao != null)
                Conexao = new SGEEntities();
            Contexto = Conexao.Set<T>();
        }

        public virtual void Incluir(T entity)
        {
            Contexto.Add(entity);
        }
        public virtual void Alterar(T entity)
        {
            Contexto.Attach(entity);
            Conexao.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Excluir(T entity)
        {
            Contexto.Remove(entity);
        }
        public virtual void Excluir(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = Contexto.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                Contexto.Remove(obj);
        }
        public virtual T Obter(long id)
        {
            return Contexto.Find(id);
        }
        public virtual T Obter(string id)
        {
            return Contexto.Find(id);
        }

        public virtual T ObterPrimeiro(Expression<Func<T, bool>> where)
        {
            return Contexto.Where(where).FirstOrDefault<T>();
        }

        public virtual IQueryable<T> ObterTodos()
        {
            return Contexto;
        }

        public virtual IQueryable<T> ObterVarios(Expression<Func<T, bool>> where)
        {
            return Contexto.Where(where);
        }

        public void Salvar()
        {
            Conexao.SaveChanges();
        }
    }
}
