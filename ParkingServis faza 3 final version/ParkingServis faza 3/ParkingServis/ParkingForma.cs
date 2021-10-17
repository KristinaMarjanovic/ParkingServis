using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingServis
{
    public partial class ParkingForma : Form
    {
        public ParkingForma()
        {
            InitializeComponent();
        }

        private void Prikazi_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.Parking>().List();



                foreach (Entiteti.Parking parking in table)
                {


                    dataGridView1.Rows.Add(parking.IdP,parking.Naziv,parking.Adresa,parking.Zona,parking.BrojParkingMesta,parking.RadnoVreme);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PrikaziParkingMesta_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            try
            {
                int idParkinga = int.Parse(textBox1.Text);
                ISession s = DataLayer.GetSession();
                Entiteti.Parking parking = s.Load<Entiteti.Parking>(idParkinga);
                foreach (Entiteti.MestoUnutarParkinga mup in parking.Mesta_unutar_parkinga)
                    dataGridView2.Rows.Add(mup.Id, mup.RedniBroj, mup.Status);
               
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
