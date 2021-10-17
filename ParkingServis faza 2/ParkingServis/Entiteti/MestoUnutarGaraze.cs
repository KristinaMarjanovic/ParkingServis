using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class MestoUnutarGaraze:Parking_Mesto
    {
        public virtual int Sprat { get; set; }
        //public virtual int IdGaraze { get; set; }
        public virtual Garaza PripadaGarazi { get; set; }
        public MestoUnutarGaraze()
        {

        }
    }
}
