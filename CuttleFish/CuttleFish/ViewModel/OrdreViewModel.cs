using CuttleFish.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttleFish.ViewModel
{
    class OrdreViewModel : DomainBase
    {
        public int KundeRefID { get; set; }
        public int ProduktListeRefID { get; set; }
        public DateTime DatoOprettet { get; set; }
        public DateTime DatoDeadline { get; set; }
        public int OrdreStatus { get; set; }
        public DateTime DatoAfsluttet { get; set; }
        public int OrdreOpretter { get; set; }
        public List<ProduktViewModel> ProduktListe { get; set; }
        public string KundeNavn { get; set; }
    }
}
