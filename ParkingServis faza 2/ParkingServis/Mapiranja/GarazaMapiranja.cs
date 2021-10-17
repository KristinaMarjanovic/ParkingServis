using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class GarazaMapiranja : ClassMap<Entiteti.Garaza>
    {
        public GarazaMapiranja()
        {
            //mapiranje tabele
            Table("GARAZA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "IDGARAZE").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Polozaj, "POLOZAJ");
            Map(x => x.MontazniObjekat, "MONTAZNIOBJEKAT");
            Map(x => x.BrojSpratova, "BROJSPRATOVA");

            //lista: 
            HasMany(x => x.Mesta_unutar_garaze).KeyColumn("IDG").Inverse().Cascade.All();

        }
    }
}
