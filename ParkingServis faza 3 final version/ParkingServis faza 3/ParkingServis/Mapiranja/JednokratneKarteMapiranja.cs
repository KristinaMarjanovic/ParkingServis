using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingServis.Entiteti;

namespace ParkingServis.Mapiranja
{
    class JednokratneKarteMapiranja : SubclassMap<JednokratneKarte>
    {
         public JednokratneKarteMapiranja()
        {
            Table("JEDNOKRATNEKARTE");
            KeyColumn("SERIJSKIBROJ");

            //mapiranje svojstava
            Map(x => x.Kiosk, "KIOSK");
          

        }
    }
}
