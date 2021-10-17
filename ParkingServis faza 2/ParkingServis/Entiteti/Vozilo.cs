using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ParkingServis.Entiteti
{
    public class Vozilo
    {
        public virtual string Model { get;  set; }
        public virtual string Proizvodjac { get; set; }
        public virtual string Reg_broj { get; set; }
        public virtual int BrojSaobracajneDozvole { get; set; }
        //public virtual int IdZ { get; set; }
        public virtual Zakupac PripadaZakupcu { get; set; }
        public virtual ZakupljujeId Zakup_MestoIVozilo { get; set; }
        public virtual Kontrola IzvrsenaJeKontrola { get; set; }
      

        public Vozilo()
        {
            
        }
    }
}
