using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    public class MestoUnutarParkinga_Mapiranja:SubclassMap<Entiteti.MestoUnutarParkinga>
    {
        public MestoUnutarParkinga_Mapiranja()
        {
            Table("MESTO_UNUTAR_PARKINGA");
            KeyColumn("ID");

            Map(x => x.RedniBroj, "REDNIBROJ");
            //Map(x => x.IdParkinga, "IDPARKINGA");
            References(x => x.Poseduje).Column("IDPARKINGA").LazyLoad();
        }

    }
}
