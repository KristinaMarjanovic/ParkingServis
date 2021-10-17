using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class VoziloMapiranja : ClassMap<ParkingServis.Entiteti.Vozilo>
    {
        public VoziloMapiranja()
        {
            //Mapiranje tabele
            Table("VOZILO");

            //mapiranje primarnog kljuca
            Id(x => x.Reg_broj, "REGBR").GeneratedBy.TriggerIdentity();

           
            Map(x => x.Model, "MODEL");
            Map(x => x.Proizvodjac, "PROIZVODJAC");
            Map(x => x.BrojSaobracajneDozvole, "BROJSAOBRACAJNEDOZVOLE");

            //Map(x => x.IdZ, "IDZAKUPCA");
            References(x => x.PripadaZakupcu).Column("IDZAKUPCA").LazyLoad();

            //Da li moze ovako?
            HasOne(x => x.Zakup_MestoIVozilo).PropertyRef(x => x.Vozilo_Zakupljuje);

            //Da li moze ovako?
            HasOne(x => x.IzvrsenaJeKontrola).PropertyRef(x => x.IdKontrole);
          
         


      



    }
    }
}