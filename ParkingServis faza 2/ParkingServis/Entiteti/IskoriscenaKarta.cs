using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class IskoriscenaKarta
    {
        public virtual IskoriscenaKartaId Id {get; set;}
        public IskoriscenaKarta()
        {
            Id = new IskoriscenaKartaId();
        }
    }
}
