using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class MestoUnutarParkinga:Parking_Mesto
    {
        public virtual int RedniBroj { get; set; }
        //public virtual int IdParkinga { get; set; }
        public virtual Parking Poseduje { get; set; }
        public MestoUnutarParkinga()
        {

        }
    }
}
