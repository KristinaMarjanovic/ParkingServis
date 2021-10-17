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
            //RADI
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Parking_Mesto pm = s.Load<Entiteti.Parking_Mesto>(123);

                MessageBox.Show("Učitano Parking Mesto : Id: " + pm.Id + ", Status mesta: " + pm.Status);

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
                u.Status = "ZAUZETO";

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

        private void ParkingMestoNaUlici_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Obelezeno_na_ulici u = s.Load<Entiteti.Obelezeno_na_ulici>(123215);

                MessageBox.Show("Učitano parking mesto na ulici : Id: " + u.Id + ", Naziv ulice: " + u.NazivUlice + ", Zona: " + u.Zona);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ParkingMestoUnutarGaraze_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.MestoUnutarGaraze u = s.Load<Entiteti.MestoUnutarGaraze>(203);

                MessageBox.Show("Učitano parking mesto u garazi : Id: " + u.Id + ", Sprat: " + u.Sprat);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ParkingMestoUnutarParkinga_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.MestoUnutarParkinga u = s.Load<Entiteti.MestoUnutarParkinga>(10);

                MessageBox.Show("Učitano parking mesto na parkingu : Id: " + u.Id + ", Redni broj: " + u.RedniBroj);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AzurirajPM_NaUlici_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Obelezeno_na_ulici u = new Entiteti.Obelezeno_na_ulici();

                u.Id = 12233;
                u.Status = "ZAUZETO";
                u.NazivUlice = "Vozda Karadjordja 32";

                s.SaveOrUpdate(u);
                MessageBox.Show("Podaci o parking mestu na ulici su promenjeni!");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void AzurirajPM_UGarazi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.MestoUnutarGaraze u = new Entiteti.MestoUnutarGaraze();

                u.Id = 203;
                u.Status = "ZAUZETO";
                u.Sprat = 3;

                s.SaveOrUpdate(u);
                MessageBox.Show("Podaci o parking mestu unutar garaze su promenjeni!");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void AzurirajPM_UnutarParkinga_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.MestoUnutarParkinga u = new Entiteti.MestoUnutarParkinga();

                u.Id = 10;
                u.Status = "ZAUZETO";
                u.RedniBroj = 20;

                s.SaveOrUpdate(u);
                MessageBox.Show("Podaci o parking mestu unutar parkinga su promenjeni!");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void UcitajParking_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Parking p = s.Load<Entiteti.Parking>(1111);

                MessageBox.Show("Učitan Parking : Id: " + p.IdP + ", Naziv: " + p.Naziv + ", Adresa: " + p.Adresa + ", Zona: " + p.Zona + ", Broj parking mesta: " + p.BrojParkingMesta + ", Radno vreme: " + p.RadnoVreme);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Parking_poseduje_mesta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Parking parking = s.Load<Parking>(1111);
                foreach (MestoUnutarParkinga mup in parking.Mesta_unutar_parkinga)
                    MessageBox.Show("Naziv parkinga: " + parking.Naziv + ", Adresa: " + parking.Adresa + " je u zoni " + parking.Zona + " i sadrzi mesto sa rednim brojem:" + mup.RedniBroj + " koje je " + mup.Status);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void AzurirajParking_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Parking u = new Entiteti.Parking();

                u.IdP = 1112;
                u.Naziv = "Parking 11";
                u.BrojParkingMesta = 30;

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

        private void ObrisiParking_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            Entiteti.Parking o = session.Load<Entiteti.Parking>(2);
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

        private void UcitajGarazu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Garaza g = s.Load<Entiteti.Garaza>(123);

                MessageBox.Show("Učitana Garaza : Id: " + g.Id + ", Polozaj: " + g.Polozaj + ", Montazni objekat: " + g.MontazniObjekat + ", Broj spratova: " + g.BrojSpratova);

                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AzurirajGarazu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Garaza g = new Entiteti.Garaza();

                g.Id = 1223;
                g.BrojSpratova = 6;
                g.Polozaj = "PODZEMNA";
                g.MontazniObjekat = "DA";

                s.SaveOrUpdate(g);
                MessageBox.Show("Podaci o garazi su promenjeni!");
                s.Flush();
                s.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void ObrisiGarazu_Click(object sender, EventArgs e)
        {
            ISession session = DataLayer.GetSession();
            Entiteti.Garaza o = session.Load<Entiteti.Garaza>(2);
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

        private void GarazaPosedujeMesta_Click(object sender, EventArgs e)
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

        private void KontolaParkingMesta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.Parking_Mesto parkingMesto = s.Load<Parking_Mesto>(123213);
                foreach (Kontrola kontrola in parkingMesto.Kontrole)
                    MessageBox.Show("Id parking mesta: " + parkingMesto.Id + ", Status: " + parkingMesto.Status + " je kontrolisano od strane kontrole sa Id-jem " + kontrola.IdKontrole + " u vreme:" + kontrola.VremeKontrole);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void ManyToMany_Click(object sender, EventArgs e)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                KartaZaParkiranje kzp = s.Load<KartaZaParkiranje>(12541);

                foreach (Kontrola k in kzp.Kontrole)
                {
                    MessageBox.Show("Id kontrole je: " + k.IdKontrole + ", period parkiranja: " + k.PeriodParkiranja.ToString());
                }

                Kontrola cntrl = s.Load<Kontrola>(12674);

                foreach (KartaZaParkiranje karta in cntrl.kontrolisaneKarte)
                {
                    MessageBox.Show("Serijski broj karte:" + karta.SerijskiBroj.ToString());
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void PrikaziPretplatneKarte_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PretplatneKarte pk = s.Load<PretplatneKarte>(1641);
                MessageBox.Show("Serijski broj karte: " + pk.SerijskiBroj);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PrikaziJednokratnuKartu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                JednokratneKarte jk = s.Load<JednokratneKarte>(1);
                MessageBox.Show("Serijski broj karte: " + jk.SerijskiBroj + ", kiosk na kom je kupljena: " + jk.Kiosk);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void IzvrsenaKontrolaNadVozilom_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kontrola k = s.Load<Kontrola>(124);
                MessageBox.Show("Id kontrole: " + k.IdKontrole + "za reg br" + k.Vozilo.Reg_broj);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void FizickoLicePosedujeVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Entiteti.FizickaLica fizickolice = s.Load<FizickaLica>(10);
                foreach (Vozilo v in fizickolice.Vozila)
                    MessageBox.Show("Fizicko lice: " + fizickolice.Ime + " " + fizickolice.Prezime + ", JMBG: " + fizickolice.Jmbg + " vozi " + v.Proizvodjac);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PravnoLicePosedujeVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PravnaLica pravnolice = s.Load<PravnaLica>(30);
                foreach (Vozilo v in pravnolice.Vozila)
                    MessageBox.Show("PIB pravnog lica: " + pravnolice.Pib + ", ime ovlascenog lica: " + pravnolice.ImeOvlascenogLica + " , naziv: " + pravnolice.Naziv + " poseduje " + v.Proizvodjac + " " + v.Model);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreiranjeUpita1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Zakupac");

                IList<Zakupac> zakupci = q.List<Zakupac>();

                foreach (Zakupac z in zakupci)
                {
                    MessageBox.Show("Id: " + z.Id + ", Adresa: " + z.Adresa);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreiranjeUpita2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //prikaz Id-jeva slobodnih parking mesta
                IQuery q = s.CreateQuery("from Parking_Mesto as pm where pm.Status = 'SLOBODNO' ");

                IList<Parking_Mesto> parkingMesta = q.List<Parking_Mesto>();

                foreach (Parking_Mesto pm in parkingMesta)
                {
                    MessageBox.Show(pm.Id + " " + pm.Status);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void KreiranjeUpitaSaParametrima_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Paramterizovani upit-parking koji ima vise od 60 mesta i radi 24h
                IQuery q = s.CreateQuery("from Parking as p where p.RadnoVreme = ? and p.BrojParkingMesta > ?");
                q.SetParameter(0, "00-24h");
                q.SetInt32(1, 60);

                IList<Parking> parkinzi = q.List<Parking>();

                foreach (Parking p in parkinzi)
                {
                    MessageBox.Show("Naziv parkinga: " + p.Naziv + ", Adresa: " + p.Adresa + ", Broj parking mesta: " + p.BrojParkingMesta);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PregledKarataZaParkiranje_Click(object sender, EventArgs e)
        {
            KarteZaParkiranje kzpInfoForm = new KarteZaParkiranje();

            kzpInfoForm.Show();
        }

        private void PregledZakupaca_Click(object sender, EventArgs e)
        {
            Zakupci zakupciInfoForm = new Zakupci();

            zakupciInfoForm.Show();
        }

        private void VozilaSve_Click(object sender, EventArgs e)
        {
            VozilaForma vozilaInfoForm = new VozilaForma();

            vozilaInfoForm.Show();
        }

        private void GarazaFormaSve_Click(object sender, EventArgs e)
        {
            GarazaForma garazaInfoForm = new GarazaForma();

            garazaInfoForm.Show();
        }

        private void ParkingForma_Click(object sender, EventArgs e)
        {
            ParkingForma parkingInfoForm = new ParkingForma();

            parkingInfoForm.Show();
        }

        private void ZakupljujeParkingMesto_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Parking_Mesto pm = s.Load<Parking_Mesto>(123);
                foreach (Zakupljuje z in pm.Zakupljuje_VoziloIZakupac)
                {
                    MessageBox.Show(z.Id.Vozilo_Zakupljuje.Proizvodjac + z.Id.Vozilo_Zakupljuje.Model);
                }


            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void Zakupljuje_Click(object sender, EventArgs e)
        {
            ZakupljujeForm zf = new ZakupljujeForm();
            zf.Show();
        }

        private void btnKontrola_Click(object sender, EventArgs e)
        {
            KontrolaForm kf = new KontrolaForm();
            kf.ShowDialog();
        }

        private void ParkingMesta_Click(object sender, EventArgs e)
        {
            ParkingMestaForma pmf = new ParkingMestaForma();
            pmf.ShowDialog();
        }
    }
}

