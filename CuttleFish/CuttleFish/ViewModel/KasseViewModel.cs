using CuttleFish.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttleFish.ViewModel
{
    class KasseViewModel : DomainBase
    {
        public string KasseNavn { get; set; }
        public int BoxTypeRefID { get; set; }
        public float BoxHoejde { get; set; }
        public float BoxLaengde { get; set; }
        public float BoxBredde { get; set; }
        public KasseViewModel()
        {

        }
        public float TotalBoxStoerrelse
        {
            get { return BoxHoejde * BoxLaengde * BoxBredde; }
        }
    }
}
