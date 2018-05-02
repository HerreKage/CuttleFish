using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuttleFish.Model.Base;

namespace CuttleFish.Model
{
    class OrdreModel<T> : DomainBase
    {
        public int KundeRefID { get; set; }
        public int ProduktListeRefID { get; set; }
        public DateTime DatoOprettet { get; set; }
        public DateTime DatoDeadline { get; set; }
        public int OrdreStatus { get; set; }
        public DateTime DatoAfsluttet { get; set; }
        public List<T> ProduktListe { get; set; }
        public string KundeNavn { get; set; }
    }
}
