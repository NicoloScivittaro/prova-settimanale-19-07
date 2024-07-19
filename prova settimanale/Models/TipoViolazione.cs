using System.ComponentModel.DataAnnotations;

namespace PoliziaMunicipaleApp.Models
{
    public class TipoViolazione
    {
        [Key]
        public int idViolazione { get; set; }

        [Required]
        [StringLength(255)]
        public string Descrizione { get; set; }
    }
}
