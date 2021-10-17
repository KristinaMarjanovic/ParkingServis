using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingServis.Entiteti
{
    public class IskoriscenaKartaId
    {
        public virtual KartaZaParkiranje Karta_PristupaU { get; set; }
        public virtual Kontrola Kontrola_PristupaU { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(IskoriscenaKartaId))
                return false;

            IskoriscenaKartaId recievedObject = (IskoriscenaKartaId)obj;

            if ((Karta_PristupaU.SerijskiBroj == recievedObject.Karta_PristupaU.SerijskiBroj) &&
                (Kontrola_PristupaU.IdKontrole == recievedObject.Kontrola_PristupaU.IdKontrole))
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
