using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class ParkingMapiranja : ClassMap<Entiteti.Parking>
    {
        public ParkingMapiranja()
        {
            //mapiranje tabele
            Table("PARKING");

            //mapiranje primarnog kljuca
            Id(x => x.IdP, "IDP").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Zona, "ZONA");
            Map(x => x.BrojParkingMesta, "BROJPARKINGMESTA");
            Map(x => x.RadnoVreme, "RADNOVREME");

            //lista:
            HasMany(x => x.Mesta_unutar_parkinga).KeyColumn("IDPARKINGA").Inverse().Cascade.All();

        }
    }
}
