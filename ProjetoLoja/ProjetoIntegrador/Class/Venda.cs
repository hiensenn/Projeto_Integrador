using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoIntegrador.Class
{
    [Table("Vendas")]
    public class Vendas
    {
        [Key]
        [Column("Id_Jogo")]
        public int Id_Jogo { get; set; }

        public string Nome { get; set; }

        public string Fabricante { get; set; }
    }
}