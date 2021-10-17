using FluentNHibernate.Mapping;
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
using ParkingServis.Mapiranja;
using NHibernate;

namespace ParkingServis
{
    public partial class KarteZaParkiranje : Form
    {
        public KarteZaParkiranje()
        {
            InitializeComponent();
        }

        private void PrikaziPretplatneKarte_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.PretplatneKarte>().List();
              
               

                foreach (Entiteti.PretplatneKarte p in table)
                {


                    dataGridView1.Rows.Add(p.SerijskiBroj,p.DatumProdaje,p.Zona,p.Klijent,p.PeriodVazenja,p.Vozilo.Reg_broj,p.Vozilo.Proizvodjac,p.Vozilo.Model);

                }
                s.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PrikaziJednokratneKarte_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                var table = s.QueryOver<Entiteti.JednokratneKarte>().List();



                foreach (Entiteti.JednokratneKarte jk in table)
                {


                    dataGridView2.Rows.Add(jk.SerijskiBroj,jk.Kiosk);

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
