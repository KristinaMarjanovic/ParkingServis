using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class PravnaLica:Zakupac
    {
        public virtual int Pib { get; set;}
        public virtual string ImeOvlascenogLica { get; set; }
        public virtual string Naziv { get; set; }
        public PravnaLica()
        {

        }
    }

}
