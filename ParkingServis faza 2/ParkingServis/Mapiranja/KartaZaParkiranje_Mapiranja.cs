using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class KartaZaParkiranje_Mapiranja : ClassMap<Entiteti.KartaZaParkiranje>
    {
        public KartaZaParkiranje_Mapiranja()
        {
            //mapiranje tabele
            Table("KARTE_ZA_PARKIRANJE");

            //mapiranje primarnog kljuca
            Id(x => x.SerijskiBroj, "SERIJSKIBROJ").GeneratedBy.TriggerIdentity();

            //Map(x => x.ZakupacId, "ZAKUPACID");

            References(x => x.PlacaKartu).Column("ZAKUPACID").LazyLoad();

            HasManyToMany(x => x.Kontrole)
                .Table("ISKORISCENA_KARTA")
                .ParentKeyColumn("SERIJSKIBROJ")
                .ChildKeyColumn("IDKONTROLA")
                .Cascade.All();

            
        }
    }
}
