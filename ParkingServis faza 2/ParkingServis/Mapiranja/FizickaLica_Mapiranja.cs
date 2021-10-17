using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    public class FizickaLica_Mapiranja:SubclassMap<Entiteti.FizickaLica>
    {
        public FizickaLica_Mapiranja()
        {
            Table("FIZICKA_LICA");
            KeyColumn("ID");

            //mapiranje svojstava
            Map(x => x.Jmbg, "JMBG");
            Map(x => x.BrojLicneKarte, "BR_LK");
            Map(x => x.MestoIzdavanja, "MESTO_IZDAVANJA_LK");
            Map(x => x.Ime, "IME");
            Map(x => x.ImeRoditelja, "SSLOVO");
            Map(x => x.Jmbg, "JMBG");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.BrojVozackeDozvole, "BRVOZDOZVOLE");
            Map(x => x.Zona, "ZONA");

        }
    }
}
