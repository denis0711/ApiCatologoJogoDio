using ApiCatologoJogoDio.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.Repositoy
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetBydId(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task Commit();
    }
}
