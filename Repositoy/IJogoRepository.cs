using ApiCatologoJogoDio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.Repositoy
{
    public interface IJogoRepository
    {
        Task<IEnumerable<Jogo>> Get();
        Task<Jogo> GetBydId(Expression<Func<Jogo, bool>> predicate);

        void Add(Jogo entity);
        void Update(Jogo entity);
        void Delete(Jogo entity);

        Task Commit();
    }
}
