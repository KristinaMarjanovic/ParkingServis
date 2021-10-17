using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class JednokratneKarte : KartaZaParkiranje
    {
        public virtual string Kiosk { get; set; }
        public JednokratneKarte()
        {

        }
    }
}
