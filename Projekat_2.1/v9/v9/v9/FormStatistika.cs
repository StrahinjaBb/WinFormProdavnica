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
    //  NESTO NE VALJA, OSTAVLJAM ZA KRAJ...
    public partial class FormStatistika : Form
    {
        List<Mesec> meseci;
        List<Proizvod> proizvodi;
        Baza baza;
        double kolicinaUkupno = 0;
        double rez = 0;
        public FormStatistika()
        {
            InitializeComponent();
            meseci = new List<Mesec>();
            proizvodi = new List<Proizvod>();
            baza = new Baza();
        }

        private double racunajCenu()
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Select * From RacunProizvod";
                OleDbDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    double kolicina = Double.Parse(reader["kolicina"].ToString());
                    kolicinaUkupno += kolicina;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }

            return kolicinaUkupno;
        }

        private void FormStatistika_Load(object sender, EventArgs e)
        {
            if (meseci.Count > 0)
                meseci.Clear();
            for(int i=1; i<=12; i++)
            {
                Mesec m = new Mesec(i);
                meseci.Add(m);
            }
            comboBoxMesec.DataSource = null;
            comboBoxMesec.DisplayMember = "naziv";
            comboBoxMesec.ValueMember = "broj";
            comboBoxMesec.DataSource = meseci;

            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Select * From Proizvod";
                OleDbDataReader reader = cmd.ExecuteReader();

                if (proizvodi.Count > 0)
                    proizvodi.Clear();

                while(reader.Read())
                {
                    Proizvod p = new Proizvod();
                    p.IdKategorija = Int32.Parse(reader["idKategorija"].ToString());
                    p.IdProizvod = Int32.Parse(reader["idProizvod"].ToString());
                    p.Naziv = reader["naziv"].ToString();
                    p.Cena = Double.Parse(reader["cena"].ToString());
                    proizvodi.Add(p);
                }

                comboBoxProizvod.DataSource = null;
                comboBoxProizvod.DisplayMember = "naziv";
                comboBoxProizvod.ValueMember = "idProizvod";
                comboBoxProizvod.DataSource = proizvodi;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }

            this.kolicinaUkupno = this.racunajCenu();
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            try
            {
                Proizvod p = proizvodi[comboBoxProizvod.SelectedIndex];
                int m = Int32.Parse(comboBoxMesec.SelectedValue.ToString());
                int ku = 0;
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = @"Select rp.kolicina
                                    From RacunProizvod rp, Racun r, Proizvod p
                                    Where rp.idRacun = r.idRacun
                                    and rp.idProizvod = p.idProizvod
                                    and r.mesec = " + m + "and p.idProizvod = " + p.IdProizvod;
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int k = Int32.Parse(reader["kolicina"].ToString());
                    ku += k;
                }

                double r1 = 100 / kolicinaUkupno;
                rez = ku * r1;
                /*
                 * float value = 92.197354542F;
                    value = (float)System.Math.Round(value,2)
                 */
                rez = (double)System.Math.Round(rez, 2);
                lblProcenat.Text = rez.ToString() + "%";
                this.Paint += crtaj;
                this.Refresh();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }
        }

        private void crtaj(object sender, PaintEventArgs e)
        {
            try
            {
                //procenat
                float broj = (float)rez;
                //360 : 100% = x : broj%
                // x = broj*100/360
                // x = broj*3.6

                if (broj <= 100 && broj >= 0)
                {
                    e.Graphics.FillEllipse(Brushes.Red, new Rectangle(640, 100, 100, 100));
                    e.Graphics.FillPie(Brushes.Blue, new Rectangle(640, 100, 100, 100), -90, (broj * 3.6F));
                }

                else
                {
                    MessageBox.Show("Nije validan procenat");
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FormStatistika_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
