using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuttleFish.Model.Base;

namespace CuttleFish.Model
{
    class ProduktModel : DomainBase
    {
        public int ProduktNummer { get; set; }
        public string ProduktNavn { get; set; }
        public string ProduktBeskrivelse { get; set; }
        public bool ProduktPaaLager { get; set; }
        public int ProduktPlacering { get; set; }
        public int BoxRefID { get; set; }
        public float ProduktPris { get; set; }
        public float ProduktPakkeStoerrelse { get; set; }
        public string KasseNavn { get; set; }
    }
}
