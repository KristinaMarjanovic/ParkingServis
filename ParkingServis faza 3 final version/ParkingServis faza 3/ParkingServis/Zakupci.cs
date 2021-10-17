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
    public partial class Zakupci : Form
    {
        public Zakupci()
        {
            InitializeComponent();
        }

        private void PrikaziFizickaLica_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.FizickaLica>().List();



                foreach (Entiteti.FizickaLica fl in table)
                {


                    dataGridView1.Rows.Add(fl.Id,fl.Ime,fl.Prezime,fl.Jmbg,fl.Adresa,fl.BrojLicneKarte,fl.BrojVozackeDozvole);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PrikaziPravnaLica_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.PravnaLica>().List();



                foreach (Entiteti.PravnaLica pl in table)
                {


                    dataGridView2.Rows.Add(pl.Id,pl.Pib,pl.Adresa,pl.ImeOvlascenogLica);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DodajZakupca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Zakupac zakupac = new Entiteti.Zakupac();

                zakupac.Id = int.Parse(textBox1.Text);
                zakupac.Adresa = textBox2.Text;
               

                s.Save(zakupac);

                MessageBox.Show("Dodat je novi zakupac");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PrikaziSveZakupce_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.Zakupac>().List();

                foreach (Entiteti.Zakupac z in table)
                {


                    dataGridView3.Rows.Add(z.Id,z.Adresa);

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

