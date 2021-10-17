using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class ZakupljujeId
    {
        public virtual Parking_Mesto ParkingMesto_Zakupljuje { get; set; }
        public virtual Zakupac Zakupac_Zakupljuje { get; set; }
        public virtual Vozilo Vozilo_Zakupljuje { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(ZakupljujeId))
                return false;

            ZakupljujeId recievedObject = (ZakupljujeId)obj;

            if ((ParkingMesto_Zakupljuje.Id == recievedObject.ParkingMesto_Zakupljuje.Id) &&
                (Zakupac_Zakupljuje.Id == recievedObject.Zakupac_Zakupljuje.Id) &&
                    (Vozilo_Zakupljuje.Reg_broj == recievedObject.Vozilo_Zakupljuje.Reg_broj))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
