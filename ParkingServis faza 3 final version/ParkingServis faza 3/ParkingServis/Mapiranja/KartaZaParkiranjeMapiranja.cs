using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    public class KartaZaParkiranjeMapiranja : ClassMap<Entiteti.KartaZaParkiranje>
    {
        public KartaZaParkiranjeMapiranja()
        {
            //mapiranje tabele
            Table("KARTE_ZA_PARKIRANJE");

            //mapiranje primarnog kljuca
            Id(x => x.SerijskiBroj, "SERIJSKIBROJ").GeneratedBy.TriggerIdentity();

            //Map(x => x.ZakupacId, "ZAKUPACID");

            //References(x => x.PlacaKartu).Column("ZAKUPACID").LazyLoad();

            HasManyToMany(x => x.Kontrole)
                .Table("ISKORISCENA_KARTA")
                .ParentKeyColumn("SERIJSKIBR")
                .ChildKeyColumn("IDKONTROLA")
                .Cascade.All();


        }
    }
}
