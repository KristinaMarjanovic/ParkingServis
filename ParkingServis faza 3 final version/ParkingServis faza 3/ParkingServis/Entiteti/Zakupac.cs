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
        //public virtual KartaZaParkiranje Placa { get; set; }
        public virtual IList<Vozilo> Vozila { get; set; }

        public virtual IList<Zakupljuje> Zakup_MestoIVozilo { get; set; }
       
        
        

        public Zakupac()
        {
            Zakup_MestoIVozilo = new List<Zakupljuje>();
            Vozila = new List<Vozilo>();
            
         
        }

    }
}
