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
    public partial class ZakupljujeForm : Form
    {
        public ZakupljujeForm()
        {
            InitializeComponent();
        }

        private void PrikaziZauzetaMesta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                var table = s.QueryOver<Entiteti.Parking_Mesto>().List();

                foreach (Parking_Mesto pm in table)
                {
                    //if (pm.Status.Equals("ZAUZETO"))
                   // {
                        //MessageBox.Show(pm.Id + pm.Status);
                        foreach (Zakupljuje z in pm.Zakupljuje_VoziloIZakupac)
                        {
                            dataGridView1.Rows.Add(pm.Id, z.Id.Zakupac_Zakupljuje.Id, z.Id.Vozilo_Zakupljuje.Reg_broj, z.Id.Vozilo_Zakupljuje.Proizvodjac,z.Id.Vozilo_Zakupljuje.Model,z.DatupPotpisaUgovora, z.Period,pm.Status);
                        }
                   // }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
