using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class PretplatneKarte:KartaZaParkiranje
    {
        public virtual DateTime DatumProdaje { get; set; }
        public virtual string Zona { get; set; }
        public virtual string Klijent { get; set; }
        public virtual DateTime PeriodVazenja { get; set; }
        //public virtual int RegBr { get; set; } 
        public virtual Vozilo Poseduje { get; set; }

        public PretplatneKarte()
        {

        }
    }
}
