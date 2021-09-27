using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v9
{
    public class Proizvod
    {
        private int idProizvoda;
        private string naziv;
        private double cena;
        private int idKategorija;

        public Proizvod(int idProizvoda, string naziv, double cena, int idKategorija)
        {
            this.idProizvoda = idProizvoda;
            this.naziv = naziv;
            this.cena = cena;
            this.idKategorija = idKategorija;
        }

        public Proizvod()
        {
            this.idProizvoda = -1;
            this.naziv = "";
            this.cena = 0;
            this.idKategorija = -1;
        }

        public int IdProizvod
        {
            get { return idProizvoda; }
            set { idProizvoda = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public int IdKategorija
        {
            get { return idKategorija; }
            set { idKategorija = value; }
        }

        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public override string ToString()
        {
            return idProizvoda.ToString() + "," + naziv + "," + cena.ToString() + "," + idKategorija.ToString();
        }
    }
}
