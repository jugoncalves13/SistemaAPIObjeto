using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaAPIObjeto.Models
{
    public class Objeto
    {
        [Column("ObjetoId")]
        [Display(Name = "Código do Objeto")]

        public int ObjetoId { get; set; }

        [Column("ObjetoNome")]
        [Display(Name = "Nome")]

        public string ObjetoNome { get; set; } = string.Empty;

        [Column("ObjetoCor")]
        [Display(Name = "Cor")]

        public string ObjetoCor { get; set; } = string.Empty;

        [Column("ObjetoObservacoes")]
        [Display(Name = "Observacão Objeto")]

        public string ObjetoObservacoes { get; set; } = string.Empty;

        [Column("ObjetoLocalDesaparecimento")]
        [Display(Name = "Local/Desaparecimento")]

        public string ObjetoLocalDesaparecimento { get; set; } = string.Empty;

        [Column("ObjetoFoto")]
        [Display(Name = "Foto")]

        public string ObjetoFoto { get; set; } = string.Empty;

        [Column("ObjetoDtDesaparecimento")]
        [Display(Name = "Data do desaparecimento")]

        public DateTime ObjetoDtDesaparecimento { get; set; }

        [Column("ObjetoDtEncontro")]
        [Display(Name = "Data do encontro")]

        public DateTime ObjetoDtEncontro { get; set; }

        [Column("ObjetoStatus")]
        [Display(Name = "Status")]

        public Byte ObjetoStatus { get; set; } 

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
