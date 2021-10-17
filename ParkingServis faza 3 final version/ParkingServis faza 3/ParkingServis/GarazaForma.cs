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
using ParkingServis.Entiteti;

namespace ParkingServis
{
    public partial class GarazaForma : Form
    {
        public GarazaForma()
        {
            InitializeComponent();
        }

       

        private void Zapamti_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Garaza g = new Entiteti.Garaza();

                g.Id = int.Parse(textBox1.Text);
                g.Polozaj = textBox2.Text;
                g.MontazniObjekat = textBox3.Text;
                g.BrojSpratova = int.Parse(textBox4.Text);
               

                s.Save(g);


                MessageBox.Show("Dodata je nova garaza!");

                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }


        private void PrikaziGaraze_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.Garaza>().List();



                foreach (Entiteti.Garaza garaza in table)
                {


                    dataGridView1.Rows.Add(garaza.Id,garaza.Polozaj,garaza.MontazniObjekat,garaza.BrojSpratova);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Obrisi_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            int id = int.Parse(textBox5.Text);
            Entiteti.Garaza g = session.Load<Entiteti.Garaza>(id);
            if (g != null)
            {
                session.Delete(g);
                MessageBox.Show("Uspesno obrisano");
            }
            else
                MessageBox.Show("Neuspesno obrisano");
            session.Flush();
            session.Close();
        }

        private void MestaUnutarGaraze_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView3.Rows.Clear();
                ISession s = DataLayer.GetSession();

                int id = int.Parse(txtIdGaraze.Text);

                Entiteti.Garaza g = s.Load<Entiteti.Garaza>(id);

                if (g.Mesta_unutar_garaze.Count > 0)
                {
                    foreach (MestoUnutarGaraze mug in g.Mesta_unutar_garaze)
                    {
                        dataGridView3.Rows.Add(mug.Sprat, mug.Status);
                    }
                }
                else
                {
                    MessageBox.Show("Nema zabelezenih mesta u bazi!");
                }



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

    
    }
}
