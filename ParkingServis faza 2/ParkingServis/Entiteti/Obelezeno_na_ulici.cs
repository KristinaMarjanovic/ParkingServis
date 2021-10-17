using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Obelezeno_na_ulici : Parking_Mesto
    {
        public virtual string NazivUlice { get; set; }
        public virtual string Zona { get; set; }
        public Obelezeno_na_ulici()
        {

        }

    }
    
  
}
