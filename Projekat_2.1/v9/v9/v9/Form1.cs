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
    public partial class Form1 : Form
    {
        Baza baza;
        List<Proizvod> proizvodi;
        List<Kategorija> kategorije;
        FormDodajProizvod fdp;
        FormRacun fr;
        FormStatistika fs;
        FormSviRacuni fsr;
        Racun r;

        public delegate void posaljiRacun(Racun r);
        public posaljiRacun posalji;

        public delegate void posaljiProizvod(Proizvod p, int kolicina);
        public posaljiProizvod pp;

        public Form1()
        {
            InitializeComponent();
            baza = new Baza();
            proizvodi = new List<Proizvod>();
            kategorije = new List<Kategorija>();
            fdp = new FormDodajProizvod();
            fr = new FormRacun();
            fs = new FormStatistika();
            fsr = new FormSviRacuni();
            r = new Racun();
        }

        private void kreirajRacun()
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = baza.Con;
                cmd1.CommandText = @"INSERT INTO 
                    Racun(dan,mesec,godina,sat,minut,sekund)
                    VALUES(@dan,@mesec,@godina,@sat,@minut,@sekund)";

                
                cmd1.Parameters.AddWithValue("dan", r.DatumVreme.Day);
                cmd1.Parameters.AddWithValue("mesec", r.DatumVreme.Month);
                cmd1.Parameters.AddWithValue("godina", r.DatumVreme.Year);
                cmd1.Parameters.AddWithValue("sat", r.DatumVreme.Hour);
                cmd1.Parameters.AddWithValue("minut", r.DatumVreme.Minute);
                cmd1.Parameters.AddWithValue("sekund", r.DatumVreme.Second);

                int rez = cmd1.ExecuteNonQuery();
                if (rez == 0)
                    MessageBox.Show("Greska: Racun nije dodat.");

                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = cmd1.Connection;
                cmd2.CommandText = @"Select idRacun 
                                    From Racun
                                    Where dan=" + r.DatumVreme.Day + " and mesec=" + r.DatumVreme.Month +
                                    " and godina=" + r.DatumVreme.Year + " and sat=" + r.DatumVreme.Hour +
                                    " and minut=" + r.DatumVreme.Minute + " and sekund=" + r.DatumVreme.Second;

                OleDbDataReader reader = cmd2.ExecuteReader();
                while(reader.Read())
                    r.IdRacun = Int32.Parse(reader["idRacun"].ToString());
                //MessageBox.Show(r.ToString());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                baza.zatvoriKonekciju();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Select * From Kategorija";
                OleDbDataReader reader = cmd.ExecuteReader();

                if (kategorije.Count > 0)
                    kategorije.Clear();

                while(reader.Read())
                {
                    Kategorija k = new Kategorija();
                    k.IdKategorija = Int32.Parse(reader["idKategorija"].ToString());
                    k.Naziv = reader["naziv"].ToString();
                    kategorije.Add(k);
                }

                comboBox1.DataSource = null;
                comboBox1.DisplayMember = "naziv";
                comboBox1.ValueMember = "idKategorija";
                comboBox1.DataSource = kategorije;

                this.kreirajRacun();
                if(r.IdRacun != 0)
                {
                    fr.Show();
                    posalji = new posaljiRacun(fr.primiRacun);
                    posalji(this.r);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                baza.zatvoriKonekciju();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Select * From Proizvod Where idKategorija=" + comboBox1.SelectedValue;
                OleDbDataReader reader = cmd.ExecuteReader();
                if (proizvodi.Count > 0)
                    proizvodi.Clear();

                while(reader.Read())
                {
                    Proizvod p = new Proizvod();
                    p.IdProizvod = Int32.Parse(reader["idProizvod"].ToString());
                    p.Naziv = reader["naziv"].ToString();
                    p.Cena = Double.Parse(reader["cena"].ToString());
                    p.IdKategorija = Int32.Parse(reader["idKategorija"].ToString());
                    proizvodi.Add(p);
                }

                IComparer<Proizvod> comparer = new MyOrderingClass();
                proizvodi.Sort(comparer);
                //List<Proizvod> proizvodiSortirano = objListProizvod.OrderBy(o => o.OrderDate).ToList();

                listBox1.DataSource = null;
                listBox1.DataSource = proizvodi;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                baza.zatvoriKonekciju();
            }
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            fdp.Show();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                Proizvod p = proizvodi[listBox1.SelectedIndex];
                MessageBox.Show(p.ToString());
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = @"INSERT INTO
                    RacunProizvod(idRacun,idProizvod,kolicina)
                    VALUES(@idRacun,@idProizvod,@kolicina)";

                int kolicina = Int32.Parse(numericUpDown1.Value.ToString());
                cmd.Parameters.AddWithValue("idRacun", r.IdRacun);
                cmd.Parameters.AddWithValue("idProizvod", p.IdProizvod);
                cmd.Parameters.AddWithValue("kolicina", kolicina);

                int rez = cmd.ExecuteNonQuery();
                if (rez == 0)
                    MessageBox.Show("Proizvod NIJE uspesno dodat.");
                else
                    MessageBox.Show("Proizvod je uspesno dodat na racun");

                pp = new posaljiProizvod(fr.primiProizvod);
                pp(p, kolicina);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            List<Proizvod> novaLista = new List<Proizvod>();
            if (novaLista.Count > 0)
                novaLista.Clear();
            List<Proizvod> proizvodi1 = new List<Proizvod>();
            List<Kategorija> kategorije1 = new List<Kategorija>();

            //  Citanje SVIH proizvoda iz baze (lista proizvodi1)
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Select * From Proizvod";
                OleDbDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Proizvod p = new Proizvod();
                    p.IdProizvod = Int32.Parse(reader["idProizvod"].ToString());
                    p.Naziv = reader["naziv"].ToString();
                    p.Cena = Double.Parse(reader["cena"].ToString());
                    p.IdKategorija = Int32.Parse(reader["idKategorija"].ToString());
                    proizvodi1.Add(p);
                }
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }
            //  Kraj iscitavanja proizvoda iz baze...

            //  Citanje proizvoda zadate kategorije iz baze (lista kategorije1)
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                cmd.CommandText = "Select * From Kategorija";
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    Kategorija k = new Kategorija();
                    k.IdKategorija = Int32.Parse(reader["idKategorija"].ToString());
                    k.Naziv = reader["naziv"].ToString();
                    kategorije1.Add(k);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { baza.zatvoriKonekciju(); }
            //  Kraj iscitavanja kategorija...
            
            if (radBtnNaziv.Checked)
            {
                foreach (Proizvod p in proizvodi1)
                {
                    if (txtPretraga.Text == p.Naziv)
                    {
                        novaLista.Add(p);
                        break;
                    }
                }

                if (novaLista.Count == 0)
                    MessageBox.Show("Trazeni proizvod se ne nalazi u bazi.");
            }

            else if (radBtnKategorija.Checked)
            {
                int idK = 0;
                foreach (Kategorija k in kategorije1)
                {
                    if (txtPretraga.Text == k.Naziv)
                        idK = k.IdKategorija;
                }

                foreach (Proizvod p in proizvodi1)
                {
                    if (p.IdKategorija == idK)
                        novaLista.Add(p);
                }
                if (novaLista.Count == 0)
                    MessageBox.Show("Nema proizvoda zadate kategorije.");
            }

            else
                MessageBox.Show("Morate oznaciti kategoriju ili naziv.");

            IComparer<Proizvod> comparer = new MyOrderingClass();
            novaLista.Sort(comparer);
            //List<Proizvod> proizvodiSortirano = objListProizvod.OrderBy(o => o.OrderDate).ToList();

            listBox1.DataSource = null;
            listBox1.DataSource = novaLista;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (baza.Con != null)
                baza.zatvoriKonekciju();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (baza.Con != null)
                baza.zatvoriKonekciju();
        }


        private void btnStatistika_Click(object sender, EventArgs e)
        {
            //  Otvara formu FormStatistika
            //  U zavisnosti od odabranog proizvoda crta statisticki prikaz prodaje
            fs.Show();
        }

        private void btnRacuni_Click(object sender, EventArgs e)
        {
            //  Otvara formu FormSviRacuni
            //  U zavisnosti od odabranog datuma prikazuje sve racune izdate tog datuma
            fsr.Show();
        }
    }
}
