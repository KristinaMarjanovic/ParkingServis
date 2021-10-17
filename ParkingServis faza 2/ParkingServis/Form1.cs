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
using ParkingServis.Mapiranja;

namespace ParkingServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sende, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Parking_Mesto u = s.Load<Entiteti.Parking_Mesto>(123);

                MessageBox.Show("Učitano Parking Mesto : Id: " + u.Id + ", Status mesta: " + u.Status);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Parking_Mesto u = new Entiteti.Parking_Mesto();

                u.Id = 123213;
                u.Status = "SLOBODNO";

                s.SaveOrUpdate(u);
                MessageBox.Show("Podaci o parking mestu su promenjeni!");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Vozilo u = s.Load<Entiteti.Vozilo>(String.Format("1253"));


                MessageBox.Show("Registarski broj: " + u.Reg_broj + ", Model: " + u.Model + ", Proizvodjac: " + u.Proizvodjac + "  Broj saobracajne dozvole: " + u.BrojSaobracajneDozvole);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Vozilo u = new Entiteti.Vozilo();

                u.BrojSaobracajneDozvole = 12345;
                u.Reg_broj = "NI-152353";

                s.SaveOrUpdate(u);
                MessageBox.Show("Podaci o vozilu su promenjeni!");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Zakupac u = s.Load<Entiteti.Zakupac>(20);

                MessageBox.Show("Id: " + u.Id + ", Adresa:" + u.Adresa);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            Entiteti.Zakupac o = session.Load<Entiteti.Zakupac>(30);
            if (o != null)
            {
                session.Delete(o);
                MessageBox.Show("Uspesno obrisano");
            }
            else
                MessageBox.Show("Neuspesno obrisano");
            session.Flush();
            session.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.FizickaLica fizickolice = s.Load<FizickaLica>(10);
                foreach (Vozilo v in fizickolice.Vozila)
                    MessageBox.Show("Fizicko lice: " + fizickolice.Ime + " " + fizickolice.Prezime + " JMBG: " + fizickolice.Jmbg + " vozi" + v.Proizvodjac);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Parking u = s.Load<Entiteti.Parking>(1111);

                MessageBox.Show("Učitan Parking : Id: " + u.IdP + ", Naziv: " + u.Naziv + ", Adresa: " + u.Adresa + ", Zona: " + u.Zona + ", Broj parking mesta: " + u.BrojParkingMesta + ", Radno vreme: " + u.RadnoVreme);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Parking u = new Entiteti.Parking();

                u.IdP = 1112;
                u.Naziv = "Parking 10";

                s.SaveOrUpdate(u);
                MessageBox.Show("Podaci o parkingu su promenjeni!");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            Entiteti.Parking o = session.Load<Entiteti.Parking>(1113);
            if (o != null)
            {
                session.Delete(o);
                MessageBox.Show("Uspesno obrisano");
            }
            else
                MessageBox.Show("Neuspesno obrisano");
            session.Flush();
            session.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Parking parking = s.Load<Parking>(2000);
                foreach (MestoUnutarParkinga mup in parking.Mesta_unutar_parkinga)
                    MessageBox.Show("Parking: " + parking.Naziv + " " + parking.Zona + " sadrzi mesta:" + mup.RedniBroj + " " + mup.Status);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Garaza u = s.Load<Entiteti.Garaza>(123);

                MessageBox.Show("Učitana Garaza : Id: " + u.Id + ", Polozaj: " + u.Polozaj + ", Montazni objekat: " + u.MontazniObjekat + ", Broj spratova: " + u.BrojSpratova);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Garaza u = new Entiteti.Garaza();

                u.Id = 1223;
                u.BrojSpratova = 6;

                s.SaveOrUpdate(u);
                MessageBox.Show("Podaci o garazi su promenjeni!");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            Entiteti.Garaza o = session.Load<Entiteti.Garaza>(1243);
            if (o != null)
            {
                session.Delete(o);
                MessageBox.Show("Uspesno obrisano");
            }
            else
                MessageBox.Show("Neuspesno obrisano");
            session.Flush();
            session.Close();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Garaza garaza = s.Load<Garaza>(123);
                foreach (MestoUnutarGaraze mug in garaza.Mesta_unutar_garaze)
                    MessageBox.Show("Garaza: Id: " + garaza.Id + " Polozaj: " + garaza.Polozaj + " Montazni objekat: " + garaza.MontazniObjekat + "Broj spratova: " + garaza.BrojSpratova + " sadrzi mesta: " + mug.Id + mug.Sprat + " " + mug.Status);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IskoriscenaKarta iskoriscena_karta = new IskoriscenaKarta();
                Entiteti.Kontrola k = s.Load<Entiteti.Kontrola>(124);

                KartaZaParkiranje k1 = s.Load<KartaZaParkiranje>(12541);

                iskoriscena_karta.Id.Karta_PristupaU = k1;
                iskoriscena_karta.Id.Kontrola_PristupaU = k;

                foreach (Entiteti.Kontrola kp in k1.Kontrole)
                {
                    MessageBox.Show(kp.IdKontrole + " " + kp.PeriodParkiranja + " " + kp.VremeKontrole);

                }

                s.Update(iskoriscena_karta);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


    }
}

