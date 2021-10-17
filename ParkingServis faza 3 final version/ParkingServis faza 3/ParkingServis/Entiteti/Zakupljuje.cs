using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Zakupljuje
    {
        public virtual ZakupljujeId Id { get; set; }
        public virtual DateTime DatupPotpisaUgovora { get; set; }
        public virtual DateTime Period { get; set; }
        public Zakupljuje()
        {
            Id = new ZakupljujeId();
        }
    }
}
