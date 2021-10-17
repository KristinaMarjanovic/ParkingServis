
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    public class KontrolaMapiranja : ClassMap<Entiteti.Kontrola>
    {
        public KontrolaMapiranja()
        {
            Table("KONTROLA");

            //mapiranje primarnog kljuca
            Id(x => x.IdKontrole, "IDKONTROLE").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.PeriodParkiranja, "PERIODPARKIRANJA");
            Map(x => x.VremeKontrole, "VREMEKONTROLE");

            References(x => x.Kontrolise).Column("IDPMESTA").LazyLoad();

            HasManyToMany(x => x.kontrolisaneKarte)
               .Table("ISKORISCENA_KARTA")
               .ParentKeyColumn("IDKONTROLA")
               .ChildKeyColumn("SERIJSKIBR")
               .Cascade.All();

            References(x => x.Vozilo).Column("REGISTARSKIBR");
        }  
    }
}
