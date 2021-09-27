using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace v9
{
    public partial class FormRacun : Form
    {
        private Racun r;
        Baza baza;
        List<RacunProizvod1> lista;
        double cenaUkupno;

        public void primiRacun(Racun r)
        {
            this.r = r;
            lblRacunID.Text = "ID racuna: " + this.r.IdRacun.ToString();
            lblDatum.Text = "Datum i vreme: " + this.r.DatumVreme.ToString();
        }
        public FormRacun()
        {
            InitializeComponent();
            baza = new Baza();
            lista = new List<RacunProizvod1>();
            cenaUkupno = 0;
        }

        public void primiProizvod(Proizvod p, int kolicina)
        {
            RacunProizvod1 rp = new RacunProizvod1(r, p, kolicina);
            lista.Add(rp);

            listBox1.DataSource = null;
            listBox1.DataSource = lista;
            cenaUkupno += p.Cena * kolicina;
            lblCenaUkupno.Text = cenaUkupno.ToString();
        }

        private void btnStornirajProizvod_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                int idP = lista[listBox1.SelectedIndex].getIdProizvoda();
                double smanji = 0;

                cmd.CommandText = @"Delete * From RacunProizvod
                    Where idRacun=" + this.r.IdRacun + " and idProizvod=" + idP;

                int rez = cmd.ExecuteNonQuery();
                if (rez == 0)
                    MessageBox.Show("Proizvod NIJE uklonjen uspesno.");
                else
                    MessageBox.Show("Proizvod je USPESNO uklonjen.");

                smanji = lista[listBox1.SelectedIndex].getCenaProizvoda() * lista[listBox1.SelectedIndex].getKolicina();
                cenaUkupno -= smanji;
                lblCenaUkupno.Text = cenaUkupno.ToString();

                lista.RemoveAt(listBox1.SelectedIndex);
                listBox1.DataSource = null;
                listBox1.DataSource = lista;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }
        }

        private void FormRacun_Load(object sender, EventArgs e)
        {

        }

        private void obrisiRacunProizvod()
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Delete * From RacunProizvod Where idRacun=" + this.r.IdRacun;
                int rez = cmd.ExecuteNonQuery();
                if (rez == 0)
                    MessageBox.Show("Atributi sa this.r.ridRacun NISU uspesno uklonjeni iz Racun.");
                else
                    MessageBox.Show("Racun " + r.IdRacun.ToString() + " je storniran.");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }
        }

        private void btnStornirajRacun_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Delete * From Racun Where idRacun=" + this.r.IdRacun;
                int rez = cmd.ExecuteNonQuery();
                if (rez == 0)
                    MessageBox.Show("Atributi sa this.r.ridRacun NISU uspesno uklonjeni iz RacunProizvod.");

                else
                    MessageBox.Show("BRISANJE RACUNA USPESNO.");

                this.obrisiRacunProizvod();
                this.Close();
            }

            catch (Exception ex ) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }
        }
    }
}
