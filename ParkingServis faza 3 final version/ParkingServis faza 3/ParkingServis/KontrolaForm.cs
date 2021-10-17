using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using ParkingServis.Entiteti;


namespace ParkingServis
{
    public partial class KontrolaForm : Form
    {
        public KontrolaForm()
        {
            InitializeComponent();
        }

        private void btnIzvrsiKontrolu_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            var table = s.QueryOver<Entiteti.Kontrola>().List();

            foreach(Kontrola k in table)
            {
                dataGridView1.Rows.Add(k.IdKontrole, k.PeriodParkiranja, k.VremeKontrole, k.Kontrolise.Id, k.Vozilo.Reg_broj);
            }

            

        }

        
    }
}
