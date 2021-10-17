using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Kontrola
    {
        public virtual int IdKontrole { get; set; }
        public virtual DateTime PeriodParkiranja { get; set; }
        public virtual DateTime VremeKontrole { get; set; }
        public virtual Parking_Mesto Kontrolise { get; set; }
        public virtual IList<KartaZaParkiranje> kontrolisaneKarte { get; set;}

        public virtual Vozilo Vozilo { get; set; }
        public Kontrola()
        {
            kontrolisaneKarte = new List<KartaZaParkiranje>();
        }

        
    }
}
