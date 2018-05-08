using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttleFish.Model
{
    class Kunde
    {

        public ObservableCollection<Kunde> _KundeInformation;
        private string _navn;
        private string _adresse;
        private string _kundeNr;
        private string _telefon;
        private string _by;
        private string _ordreNr;


       public string Navn {get => _navn; set => _navn = value;}
        public string Adresse{ get => _adresse; set => _adresse = value; }
        public string KundeNr { get => _kundeNr; set => _kundeNr = value; }
        public string Telefon { get => _navn; set => _navn = value; }
        public string By { get => _navn; set => _navn = value; }
        public string ordreNr { get => _ordreNr; set => _ordreNr = value; }


        public Kunde()

        {
            Kunde kunde1 = new Kunde();

            kunde1.Navn = "LarsNoget";
            kunde1.Adresse = "Voldsmose 12";
            kunde1.KundeNr = "1";
            kunde1.Telefon = "1123321";
            kunde1.By = "Odense";
            kunde1.ordreNr = "22";


            Kunde kunde2=new Kunde();

            kunde2.Navn = "SmukkeLasse";
            kunde2.Adresse = "VedElisagårdsvej 45";
            kunde2.KundeNr = "23";
            kunde2.Telefon = "22222222";
            kunde2.By = "Roskilde";
            kunde2.ordreNr = "44";

            Kunde kunde3=new Kunde();

            kunde3.Navn = "Jens Niels Jensen";
            kunde3.Adresse = "bygaden 13";
            kunde3.KundeNr = "4";
            kunde3.Telefon = "71423451";
            kunde3.By = "Dragør";
            kunde3.ordreNr = "24";


        } 
        
        public ObservableCollection<Kunde> KundeInfo { get =>_KundeInformation; set => _KundeInformation=value;}



    }
}
