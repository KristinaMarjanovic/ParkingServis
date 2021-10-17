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
    public partial class ParkingMestaForma : Form
    {
        public ParkingMestaForma()
        {
            InitializeComponent();
        }

        private void PrikaziSvaParkingMesta_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.Parking_Mesto>().List();



                foreach (Entiteti.Parking_Mesto pm in table)
                {


                    dataGridView1.Rows.Add(pm.Id, pm.Status);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ObrisiParkingMesto_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            int id = int.Parse(textBox1.Text);
            Entiteti.Parking_Mesto pm = session.Load<Entiteti.Parking_Mesto>(id);
            if (pm != null)
            {
                session.Delete(pm);
                MessageBox.Show("Uspesno obrisano");
            }
            else
                MessageBox.Show("Neuspesno obrisano");
            session.Flush();
            session.Close();
        }

        private void PrikaziMestaNaUlici_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.Obelezeno_na_ulici>().List();



                foreach (Entiteti.Obelezeno_na_ulici onu in table)
                {


                    dataGridView2.Rows.Add(onu.Id,onu.NazivUlice,onu.Status);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PrikaziMestaUnutarParkinga_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.MestoUnutarParkinga>().List();



                foreach (Entiteti.MestoUnutarParkinga mup in table)
                {


                    dataGridView3.Rows.Add(mup.Id,mup.Poseduje.IdP,mup.RedniBroj,mup.Status);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PrikaziParkingMestaUnutarGaraze_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.MestoUnutarGaraze>().List();



                foreach (Entiteti.MestoUnutarGaraze mug in table)
                {


                    dataGridView4.Rows.Add(mug.Id,mug.PripadaGarazi.Id,mug.Sprat,mug.Status);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}


