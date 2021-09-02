using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.DTOs
{
    public class ProdutoraDTO
    {
        public int ProdutoraId { get; set; }

        public string Nome { get; set; }



        public ICollection<JogoDto> Jogos { get; set; }
    }
}
