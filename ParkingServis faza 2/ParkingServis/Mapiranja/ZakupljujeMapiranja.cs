using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class ZakupljujeMapiranja:ClassMap<Entiteti.Zakupljuje>
    {
        public ZakupljujeMapiranja()
        {
            //mapiranje tabele
            Table("ZAKUPLJUJE");

            Map(x => x.DatupPotpisaUgovora, "DATUMPOTPISA");
            Map(x => x.Period, "PERIOD");

            CompositeId(x => x.Id)
                .KeyReference(x => x.ParkingMesto_Zakupljuje, "IDPARKMESTA")
                .KeyReference(x => x.Vozilo_Zakupljuje, "REGBRVOZILA")
                .KeyReference(x => x.Zakupac_Zakupljuje, "ID_ZAKUPCA");
        }
    }
}
