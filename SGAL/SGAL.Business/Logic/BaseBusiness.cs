using SGAL.Core;
using System.Collections.Generic;
using SGAL.Repositorio.Logic;

namespace SGAL.Business.Logic
{
    public class BaseBusiness<T> where T : class
    {
        public readonly BaseRepository<T> repositorio;

        protected BaseBusiness()
        {
            this.repositorio = new BaseRepository<T>();
        } 

        public interface IBaseBusiness
        {
            IEnumerable<Validacao> PreIncluir(T entity);
            IEnumerable<Validacao> PosIncluir(T entity);
            IEnumerable<Validacao> PreAlterar(T entity);
            IEnumerable<Validacao> PosAlterar(T entity);
            IEnumerable<Validacao> PreExcluir(T entity);
            IEnumerable<Validacao> PosExcluir(T entity);
        }
    }
}
