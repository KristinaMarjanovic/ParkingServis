using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    public class ObelezenoNaUlici_Mapiranja : SubclassMap<Entiteti.Obelezeno_na_ulici>
    {
        public ObelezenoNaUlici_Mapiranja()
        {
            Table("OBELEZENO_NA_ULICI");
            KeyColumn("ID");
            Map(x => x.NazivUlice, "NAZIV_ULICE");
            Map(x => x.Zona, "ZONA");

        }
        


    }
}
