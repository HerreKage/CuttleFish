using CuttleFish.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttleFish.ViewModel
{
    class KundeViewModel : DomainBase
    {
        public string KundeNavn { get; set; }
        public int KundeCVR { get; set; }
        public int KundeTelefonListeRefID { get; set; }
        public string KundeMail { get ; set; }
        public Dictionary<int, int> KundeTelefonListe { get; set; }
        public KundeViewModel()
        {
            
        }
    }
}
