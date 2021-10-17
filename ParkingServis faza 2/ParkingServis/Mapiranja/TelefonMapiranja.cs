using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class TelefonMapiranja: ClassMap<Entiteti.Telefon>
    {
        public TelefonMapiranja()
        {
            Table("TELEFON");
            Id(x => x.IdZakupca, "ZAKUPACBR").GeneratedBy.Increment();
            Map(x => x.BrojTelefona, "TELEFON");
            References(x => x.PripadaZakupcu, "ZAKUPACBR").LazyLoad();
        }
    }
}
