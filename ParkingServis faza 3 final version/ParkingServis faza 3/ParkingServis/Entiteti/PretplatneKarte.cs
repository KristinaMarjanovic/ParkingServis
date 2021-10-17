using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
   public class PretplatneKarte : KartaZaParkiranje
    {
       public virtual DateTime DatumProdaje { get; set; }
       public virtual String Zona { get; set; }
       public virtual String Klijent { get; set; }
       public virtual DateTime PeriodVazenja { get; set; }
       public virtual Vozilo Vozilo { get; set; }

       public PretplatneKarte() { }
    }
}
