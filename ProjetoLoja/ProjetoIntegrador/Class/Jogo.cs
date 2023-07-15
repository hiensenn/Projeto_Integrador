using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoIntegrador.Class
{
    [Table("Jogos")]
    public class Jogo
    {
        [Key]
        [Column("Id_Jogo")]
        public int Id_Jogo { get; set; }
        int Id { get; set; }
        public string NomeJogo { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
    }
}