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
    public partial class FormDodajProizvod : Form
    {
        Baza baza;
        List<Kategorija> lista;
        public FormDodajProizvod()
        {
            InitializeComponent();
            lista = new List<Kategorija>();
            baza = new Baza();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;

                Proizvod p = new Proizvod();
                p.Naziv = txtNaziv.Text;
                p.Cena = Double.Parse(txtCena.Text);
                p.IdKategorija = Int32.Parse(comboBox1.SelectedValue.ToString());

                cmd.CommandText = @"INSERT INTO Proizvod(naziv,cena,idKategorija)
                    VALUES(@naziv,@cena,@idKategorija)";

                cmd.Parameters.AddWithValue("naziv", p.Naziv);
                cmd.Parameters.AddWithValue("cena", p.Cena);
                cmd.Parameters.AddWithValue("idKategorija", p.IdKategorija);
                

                int rez = cmd.ExecuteNonQuery();
                if (rez == 0)
                    MessageBox.Show("Greska: Nista nije dodato.");
                else
                    MessageBox.Show("Uspesno ste dodali proizvod.");

                this.Close();
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

        private void FormDodajProizvod_Load(object sender, EventArgs e)
        {
            try
            {
                baza.otvoriKonekciju();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = baza.Con;
                if (lista.Count > 0)
                    lista.Clear();

                cmd.CommandText = "SELECT * FROM Kategorija";
                OleDbDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Kategorija k = new Kategorija();
                    k.IdKategorija = Int32.Parse(reader["idKategorija"].ToString());
                    k.Naziv = reader["naziv"].ToString();
                    lista.Add(k);
                }

                comboBox1.DataSource = null;
                comboBox1.DisplayMember = "naziv";
                comboBox1.ValueMember = "idKategorija";
                comboBox1.DataSource = lista;
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
    }
}
