using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class ZakupacMapiranja : ClassMap<Entiteti.Zakupac>
    {
        public ZakupacMapiranja()
        {
            //mapiranje tabele
            Table("ZAKUPAC");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstva
            Map(x => x.Adresa, "ADRESA");

            HasMany(x => x.Vozila).KeyColumn("IDZAKUPCA").LazyLoad();

            HasMany(x => x.Zakup_MestoIVozilo).KeyColumn("ID_ZAKUPCA");

            


            //HasOne(x => x.Placa).PropertyRef(x => x.SerijskiBroj);

            //Da li moze ovako?
            //HasOne(x => x.Zakup_MestoIVozilo).PropertyRef(x => x.Zakupac_Zakupljuje);
            //References(x => x.Zakup_MestoIVozilo).Column("ID_ZAKUPCA").LazyLoad();

        }
    }
}
