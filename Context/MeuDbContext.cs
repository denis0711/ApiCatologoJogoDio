using ApiCatologoJogoDio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.Context
{
    public class MeuDbContext : IdentityDbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {

        }

        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Produtora> Produtoras { get; set; }
    }
}
