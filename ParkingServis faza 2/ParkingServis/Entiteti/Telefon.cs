using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Telefon
    {
        public virtual int BrojTelefona { get; set; }
        public virtual int IdZakupca { get; set; }
        public virtual Zakupac PripadaZakupcu { get; set; }
    }
}
