using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    public class MestoUnutarGaraze_Mapiranja:SubclassMap<Entiteti.MestoUnutarGaraze>
    {
        public MestoUnutarGaraze_Mapiranja()
        {
            Table("MESTO_UNUTAR_GARAZE");
            KeyColumn("ID");

            Map(x => x.Sprat, "SPRAT");
            //Map(x => x.IdGaraze, "IDG");
            References(x => x.PripadaGarazi).Column("IDG").LazyLoad();
        }
    }
}
