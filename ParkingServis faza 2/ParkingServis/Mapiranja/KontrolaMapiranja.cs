using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class KontrolaMapiranja: ClassMap<Entiteti.Kontrola>
    {
        public KontrolaMapiranja()
        {
            //mapiranje tabele
            Table("KONTROLA");

            //mapiranje primarnog kljuca
            Id(x => x.IdKontrole, "IDKONTROLE").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.PeriodParkiranja, "PERIODPARKIRANJA");
            Map(x => x.VremeKontrole, "VREMEKONTROLE");
            
            /*
            Map(x => x.IdParkingMesta, "IDPMESTA");
            Map(x => x.RegBr, "REGISTARSKIBR");
            */

            HasManyToMany(x => x.IskoriscenaJeKarta)
                .Table("ISKORISCENA_KARTA")
                .ParentKeyColumn("IDKONTROLA")
                .ChildKeyColumn("SERIJSKIBROJ")
                .Inverse()
                .Cascade.All();

            References(x => x.Kontrolise).Column("IDPMESTA").LazyLoad();
            References(x => x.IzvrsenaKontrola).Column("REGISTARSKIBR").LazyLoad();
            
           
        }
    }
}
