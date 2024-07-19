using System.Collections.Generic;

namespace PoliziaMunicipaleApp.Models
{
    public class VerbaleViewModel
    {
        public Verbale Verbale { get; set; }
        public List<Anagrafica> Anagrafica { get; set; }
        public List<TipoViolazione> TipoViolazione { get; set; }
    }
}