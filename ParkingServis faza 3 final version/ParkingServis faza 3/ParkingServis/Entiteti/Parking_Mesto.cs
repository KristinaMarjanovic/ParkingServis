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
        public virtual IList<Zakupljuje> Zakupljuje_VoziloIZakupac { get; set; }
        
        public Parking_Mesto()
        {
            Zakupljuje_VoziloIZakupac = new List<Zakupljuje>(); 
            Kontrole = new List<Kontrola>();
        }


        
    }
   

   

   

   
}
