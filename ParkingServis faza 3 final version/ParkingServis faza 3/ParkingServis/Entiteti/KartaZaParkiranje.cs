using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class KartaZaParkiranje
    {
        public virtual int SerijskiBroj { get; set; }
        
        //public virtual int ZakupacId { get; set; } 

        //public virtual Zakupac PlacaKartu { get; set; }
        public virtual IList<Kontrola> Kontrole { get; set; }

        public KartaZaParkiranje()
        {
            Kontrole = new List<Kontrola>();
        }
    }






}
