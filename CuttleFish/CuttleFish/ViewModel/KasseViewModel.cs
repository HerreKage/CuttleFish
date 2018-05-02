using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttleFish.ViewModel
{
    class KasseViewModel
    {
        public string KasseNavn { get; set; }
        public int BoxTypeRefID { get; set; }
        public float BoxHoejde { get; set; }
        public float BoxLaengde { get; set; }
        public float BoxBredde { get; set; }
        private float _BoxAreal;
        public KasseViewModel()
        {

        }
        public float BoxAreal
        {
            get { return BoxHoejde * BoxLaengde * BoxBredde; }
        }
    }
}
