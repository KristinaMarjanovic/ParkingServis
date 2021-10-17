using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Parking
    {
        public virtual int IdP {get;set;}
        public virtual string Naziv { get; set; }
        public virtual string  Adresa { get; set; }
        public virtual string Zona { get; set; }
        public virtual int BrojParkingMesta { get; set; }
        public virtual string RadnoVreme { get; set; }

        public virtual IList<MestoUnutarParkinga> Mesta_unutar_parkinga { get; set; }



    }
}
