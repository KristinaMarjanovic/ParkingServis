using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using FluentNHibernate.Mapping;

namespace ParkingServis.Mapiranja
{
    class IskoriscenaKarta_Mapiranja : ClassMap<ParkingServis.Entiteti.IskoriscenaKarta>
    {
        public IskoriscenaKarta_Mapiranja()
        {
            //Mapiranje tabele
            Table("ISKORISCENA_KARTA");

            CompositeId(x => x.Id)
                .KeyReference(x => x.Karta_PristupaU, "SERIJSKIBR")
                .KeyReference(x => x.Kontrola_PristupaU, "IDKONTROLA");

           


           


        }
    }
}
    
    

