using System;

namespace ApiCatologoJogoDio.DTOs
{
    public class JogoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int ProdutoraId { get; set; }
        public double Preco { get; set; }

    }
}
