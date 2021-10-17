using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Zakupac
    {
        public virtual int Id { get; set; }
        public virtual string Adresa { get; set; }
        public virtual KartaZaParkiranje Placa { get; set; } 
        public virtual IList<Vozilo>Vozila { get; set; } 
        public virtual ZakupljujeId Zakup_MestoIVozilo { get; set; }

        public Zakupac()
        {
            Vozila = new List<Vozilo>();
        }

    }
    
    

  

}
