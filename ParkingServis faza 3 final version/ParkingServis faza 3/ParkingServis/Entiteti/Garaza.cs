using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Garaza
    {
        public virtual int Id { get; set; }
        public virtual string Polozaj { get; set; }
        public virtual string MontazniObjekat { get; set; }
        public virtual int BrojSpratova { get; set; }
        public virtual IList<MestoUnutarGaraze> Mesta_unutar_garaze { get; set; }

        public Garaza()
        {
            Mesta_unutar_garaze = new List<MestoUnutarGaraze>();
        }
    }
}
