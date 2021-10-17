using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class FizickaLica : Zakupac
    {
        public virtual int Jmbg { get; set; }
        public virtual int BrojLicneKarte { get; set; }
        public virtual string MestoIzdavanja { get; set; }
        public virtual string Ime { get; set; }
        public virtual string ImeRoditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int BrojVozackeDozvole { get; set; }
        public virtual string Zona { get; set; }
        public FizickaLica()
        {

        }
    }
}
