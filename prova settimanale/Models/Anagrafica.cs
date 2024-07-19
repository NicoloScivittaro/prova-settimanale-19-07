using System.ComponentModel.DataAnnotations;

namespace PoliziaMunicipaleApp.Models
{
    public class Anagrafica
    {
        [Key]
        public int idAnagrafica { get; set; }  

        [Required]
        [StringLength(50)]
        public string Cognome { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Indirizzo { get; set; }

        [StringLength(50)]
        public string Citta { get; set; }

        [StringLength(10)]
        public string CAP { get; set; }

        [StringLength(16)]
        public string Cod_Fisc { get; set; }
    }
}