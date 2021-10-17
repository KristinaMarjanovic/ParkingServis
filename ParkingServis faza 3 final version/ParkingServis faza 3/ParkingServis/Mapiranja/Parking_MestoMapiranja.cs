using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class Parking_MestoMapiranja : ClassMap<Entiteti.Parking_Mesto>
    {
        public Parking_MestoMapiranja()
        {
            //Mapiranje tabele
            Table("PARKINGMESTO");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

           //mapiranje svojstava
            Map(x => x.Status, "STATUS");

            
            //lista
            HasMany(x => x.Kontrole).KeyColumn("IDPMESTA");

            //Koje od ova dva? Mislim da moze prvo:
            HasMany(x => x.Zakupljuje_VoziloIZakupac).KeyColumn("IDPARKMESTA");
           //References(x => x.Zakup_VoziloIZakupac).Column("IDPARKMESTA").LazyLoad();
            
            //HasOne(x => x.Zakup_VoziloIZakupac).PropertyRef(x => x.ParkingMesto_Zakupljuje);
            

        }
    }
}
