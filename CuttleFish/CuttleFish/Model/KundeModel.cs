using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuttleFish.Model.Base;

namespace CuttleFish.Model
{
    class KundeModel<T> : DomainBase
    {
        public string KundeNavn { get; set; }
        public int KundeCVR { get; set; }
        public int KundeTelefonListeRefID { get; set; }
        public string KundeMail { get; set; }
        public List<int> KundeTelefonListe { get; set; }
    }
}
