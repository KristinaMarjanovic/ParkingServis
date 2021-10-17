using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    public class PretplatneKarte_Mapiranja:SubclassMap<Entiteti.PretplatneKarte>
    {
        public PretplatneKarte_Mapiranja()
        {
            Table("PRETPLATNE_KARTE");
            KeyColumn("SERIJSKIBROJ");

            //mapiranje svojstava
            Map(x => x.DatumProdaje, "DATUMPRODAJE");
            Map(x => x.Zona, "ZONA");
            Map(x => x.Klijent, "KLIJENT");
            Map(x => x.PeriodVazenja, "PERIODVAZENJA");

            //Map(x => x.RegBr, "REGBROJ");

            References(x => x.Poseduje).Column("REGBROJ").LazyLoad();
        }
    }
}
