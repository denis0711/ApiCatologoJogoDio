using ApiCatologoJogoDio.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.Repositoy
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MeuDbContext _meuDbContext;

        public Repository(MeuDbContext meuDbContext)
        {
            _meuDbContext = meuDbContext;
        }
        public void Add(T entity)
        {
            _meuDbContext.Set<T>().Add(entity);
        }

        public async Task Commit()
        {
            await _meuDbContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            _meuDbContext.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await  _meuDbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> GetBydId(Expression<Func<T, bool>> predicate)
        {
            return await _meuDbContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(predicate);
        }

        public void Update(T entity)
        {
            _meuDbContext.Entry(entity).State = EntityState.Modified;
            _meuDbContext.Set<T>().Update(entity);
        }
    }
}
