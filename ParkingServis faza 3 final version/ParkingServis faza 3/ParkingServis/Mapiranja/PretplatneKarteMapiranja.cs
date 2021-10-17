using ParkingServis.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class PretplatneKarteMapiranja : SubclassMap<PretplatneKarte>
    {
        public PretplatneKarteMapiranja()
        {
            Table("PRETPLATNE_KARTE");
            KeyColumn("SERIJSKIBROJ");

            //mapiranje svojstava
            Map(x => x.DatumProdaje, "DATUMPRODAJE");
            Map(x => x.Zona, "ZONA");
            Map(x => x.Klijent, "KLIJENT");
            Map(x => x.PeriodVazenja, "PERIODVAZENJA");

            //Map(x => x.RegBr, "REGBROJ");

            References(x => x.Vozilo).Column("REGBROJ").LazyLoad();
        }
    }
}
