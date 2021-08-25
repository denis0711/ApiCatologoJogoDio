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
        [StringLength(80, ErrorMessage = "O Campo deve ter no maximo 80 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(8,2")]
        public double Preco { get; set; }
    }
}
