using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuttleFish.Model.Base;

namespace CuttleFish.Model
{
    class KasseModel : DomainBase
    {
        public string KasseNavn { get; set; }
        public int BoxTypeRefID { get; set; }
        public float BoxHoejde { get; set; }
        public float BoxLaengde { get; set; }
        public float BoxBredde { get; set; }
    }
}
