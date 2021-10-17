using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class JednokratneKarte_Mapiranja:SubclassMap<Entiteti.JednokratneKarte>
    {
        public JednokratneKarte_Mapiranja()
        {
            Table("JEDNOKRATNEKARTE");
            KeyColumn("SERIJSKIBROJ");

            Map(x => x.Kiosk, "KIOSK");
        }
    }
}
