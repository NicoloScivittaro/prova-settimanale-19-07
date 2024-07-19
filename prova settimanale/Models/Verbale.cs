using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoliziaMunicipaleApp.Models
{
    public class Verbale
    {
        [Key]
        public int IdVerbale { get; set; }

        [Required]
        public DateTime DataViolazione { get; set; }

        [StringLength(100)]
        public string IndirizzoViolazione { get; set; }

        [StringLength(50)]
        public string Nominativo_Agente { get; set; }

        public DateTime DataTrascrizioneVerbale { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Importo { get; set; }

        public int DecurtamentoPunti { get; set; }

        public int? idAnagrafica { get; set; }
        public Anagrafica Anagrafica { get; set; }

        public int? IdViolazione { get; set; }
        public TipoViolazione TipoViolazione { get; set; }
    }
}
