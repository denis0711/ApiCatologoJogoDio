using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.Models
{
    [Table("Produtoras")]
    public class Produtora
    {
        public Produtora()
        {
            Jogos = new Collection<Jogo>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "O Campo deve ter no maximo 80 caracteres")]
        public string Nome { get; set; }

        public ICollection<Jogo> Jogos { get; set; }
    }
}
