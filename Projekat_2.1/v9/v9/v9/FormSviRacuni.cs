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
    public partial class FormSviRacuni : Form
    {
        Baza baza;
        List<Racun> listaRacuna;
        public FormSviRacuni()
        {
            InitializeComponent();
            listaRacuna = new List<Racun>();
            baza = new Baza();
        }

        private void btnIzlistaj_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime pocetni = dtpPocetni.Value;
                DateTime krajnji = dtpKrajnji.Value;

                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Select * From Racun";
                OleDbDataReader reader = cmd.ExecuteReader();

                if (listaRacuna.Count > 0)
                    listaRacuna.Clear();

                while(reader.Read())
                {
                    Racun r = new Racun();
                    r.IdRacun = Int32.Parse(reader["idRacun"].ToString());
                    r.CenaUkupno = Double.Parse(reader["cenaUkupno"].ToString());
                    int dan, mesec, godina, sat, minut, sekund;
                    dan = Int32.Parse(reader["dan"].ToString());
                    mesec = Int32.Parse(reader["mesec"].ToString());
                    godina = Int32.Parse(reader["godina"].ToString());
                    sat = Int32.Parse(reader["sat"].ToString());
                    minut = Int32.Parse(reader["minut"].ToString());
                    sekund = Int32.Parse(reader["sekund"].ToString());
                    // int dan, int mesec, int godina, int sat, int minut, int sekunda
                    r.setDatumVreme(dan, mesec, godina, sat, minut, sekund);

                    int p = DateTime.Compare(r.DatumVreme, pocetni);
                    int k = DateTime.Compare(krajnji, r.DatumVreme);

                    if(p>=0 && k>=0)
                        listaRacuna.Add(r);
                }

                listBox1.DataSource = null;
                listBox1.DataSource = listaRacuna;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }
        }

        private void btnIzlistajSve_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Select * From Racun";
                OleDbDataReader reader = cmd.ExecuteReader();
                if (listaRacuna.Count > 0)
                    listaRacuna.Clear();

                while(reader.Read())
                {
                    Racun r = new Racun();
                    r.IdRacun = Int32.Parse(reader["idRacun"].ToString());
                    r.CenaUkupno = Double.Parse(reader["cenaUkupno"].ToString());
                    int dan, mesec, godina, sat, minut, sekund;
                    dan = Int32.Parse(reader["dan"].ToString());
                    mesec = Int32.Parse(reader["mesec"].ToString());
                    godina = Int32.Parse(reader["godina"].ToString());
                    sat = Int32.Parse(reader["sat"].ToString());
                    minut = Int32.Parse(reader["minut"].ToString());
                    sekund = Int32.Parse(reader["sekund"].ToString());
                    // int dan, int mesec, int godina, int sat, int minut, int sekunda
                    r.setDatumVreme(dan, mesec, godina, sat, minut, sekund);

                    listaRacuna.Add(r);
                }

                listBox1.DataSource = null;
                listBox1.DataSource = listaRacuna;
            }

            catch (Exception ex ) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }
        }
    }
}
