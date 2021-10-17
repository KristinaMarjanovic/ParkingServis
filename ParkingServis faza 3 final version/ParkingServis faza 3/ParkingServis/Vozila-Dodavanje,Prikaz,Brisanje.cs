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
    public partial class VozilaForma : Form
    {
        public VozilaForma()
        {
            InitializeComponent();
        }

        private void DodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Vozilo vozilo = new Entiteti.Vozilo();

                vozilo.Reg_broj = int.Parse(textBox1.Text);
                vozilo.Proizvodjac = textBox2.Text;
                vozilo.Model = textBox3.Text;
                vozilo.BrojSaobracajneDozvole = int.Parse(textBox4.Text);
                //vozilo.PripadaZakupcu.Id = int.Parse(textBox5.Text);


                s.Save(vozilo);

                MessageBox.Show("Dodato je novo vozilo");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PrikaziVozila_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.Vozilo>().List();



                foreach (Entiteti.Vozilo vozilo in table)
                {


                    dataGridView1.Rows.Add(vozilo.Reg_broj, vozilo.Proizvodjac, vozilo.Model, vozilo.BrojSaobracajneDozvole);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Obrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                bool b = false;

                //    Entiteti.Operater u = s.Load<Entiteti.Operater>(5);

                var table = s.QueryOver<Entiteti.Vozilo>().List();
                foreach (Entiteti.Vozilo v in table)
                {
                    if (int.Parse(textBox5.Text) == v.Reg_broj)
                    {


                        s.Delete(v);
                        b = true;

                    }
                }
                if (b == true)
                {
                    MessageBox.Show("Vozilo je obrisano!");
                }
                else
                {
                    MessageBox.Show("Pogresan registarski broj!");
                }

                s.Flush();
                s.Close();
            }
            catch (Exception exc)

            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
