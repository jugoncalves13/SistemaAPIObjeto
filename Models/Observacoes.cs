using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaAPIObjeto.Models
{
    public class Observacoes
    {
        [Column("ObservacoesId")]
        [Display(Name = "Código do Observacoes")]

        public int ObservacoesId { get; set; }

        [Column("ObservacoesDescricao")]
        [Display(Name = "Descrição")]

        public string ObservacoesDescricao { get; set; } = string.Empty;

        [Column("ObservacoesLocal")]
        [Display(Name = "Local")]

        public string ObservacoesLocal { get; set; } = string.Empty;

        [Column("ObservacoesData")]
        [Display(Name = "Data")]

        public DateTime ObservacoesData { get; set; }

        [ForeignKey("ObjetoId")]
        public int ObjetoId { get; set; }
        public Objeto? Objeto { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

    }
}
