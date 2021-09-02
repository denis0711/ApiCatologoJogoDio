using ApiCatologoJogoDio.Context;
using ApiCatologoJogoDio.Models;

namespace ApiCatologoJogoDio.Repositoy
{
    public class ProdutraRepository : Repository<Produtora> , IProdutoraRepository
    {
        public ProdutraRepository(MeuDbContext meuDbContext) : base(meuDbContext)
        {

        }

    }
}
