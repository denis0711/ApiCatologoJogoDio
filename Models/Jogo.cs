using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatologoJogoDio.Models
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "O Campo deve ter no maximo 80 caracteres")]
        public string Nome { get; set; }

   
        [Required]
       
        public double Preco { get; set; }

        public Produtora Produtora { get; set; }

        public int ProdutoraId { get; set; }


    }
}
