using ApiCatologoJogoDio.Context;
using ApiCatologoJogoDio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.Repositoy
{
    public class JogoRepository : IJogoRepository
    {
        private readonly MeuDbContext _meuDbContext;

        public JogoRepository(MeuDbContext meuDbContext)
        {
            _meuDbContext = meuDbContext;
        }
        public void Add(Jogo entity)
        {
            _meuDbContext.Set<Jogo>().Add(entity);
        }

        public void Delete(Jogo entity)
        {
            _meuDbContext.Set<Jogo>().Remove(entity);
        }

        public async Task<IEnumerable<Jogo>> Get()
        {
            return  _meuDbContext.Set<Jogo>().AsNoTracking();
        }

        public async Task<Jogo> GetBydId(Expression<Func<Jogo, bool>> predicate)
        {
            return await _meuDbContext.Set<Jogo>().AsNoTracking().SingleOrDefaultAsync(predicate);
        }

        public void Update(Jogo entity)
        {
            _meuDbContext.Entry(entity).State = EntityState.Modified;
            _meuDbContext.Set<Jogo>().Update(entity);
        }

        public async Task Commit()
        {
            await _meuDbContext.SaveChangesAsync();
        }


    }
}
