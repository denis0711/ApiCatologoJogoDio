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
    public class JogoRepository : Repository<Jogo> , IJogoRepository
    {

        public JogoRepository(MeuDbContext meuDbContext) : base (meuDbContext)
        {

        }

    }
}
