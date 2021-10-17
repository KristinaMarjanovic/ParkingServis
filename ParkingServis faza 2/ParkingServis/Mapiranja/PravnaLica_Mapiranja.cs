using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    public class PravnaLica_Mapiranja:SubclassMap<Entiteti.PravnaLica>
    {
        public PravnaLica_Mapiranja()
        {
            Table("PRAVNA_LICA");
            KeyColumn("ID");

            //mapiranje svojstava
            Map(x => x.Pib, "PIB");
            Map(x => x.ImeOvlascenogLica, "IME_OVLASCENOG_LICA");
            Map(x => x.Naziv, "NAZIV");
        }
    }
}
