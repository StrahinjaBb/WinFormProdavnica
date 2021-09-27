using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v9
{
    public class Kategorija
    {
        private int idKategorija;
        private string naziv;

        public Kategorija(int idKategorija, string naziv)
        {
            this.idKategorija = idKategorija;
            this.naziv = naziv;
        }

        public Kategorija()
        {
            this.idKategorija = -1;
            this.naziv = "";
        }

        public int IdKategorija
        {
            get { return idKategorija; }
            set { idKategorija = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public override string ToString()
        {
            return idKategorija.ToString() + "," + naziv;
        }
    }
}
