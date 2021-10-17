using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class Parking_Mesto
    {
        public virtual int Id { get; set; }
        public virtual string Status { get; set; }
        public virtual IList<Kontrola> Kontrole { get; set; }
       
        //
        public virtual ZakupljujeId Zakup_VoziloIZakupac { get; set; }
        
        public Parking_Mesto()
        {
            Kontrole = new List<Kontrola>();
        }


        
    }
   

   

   

   
}
