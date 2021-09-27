using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v9
{
    public class Mesec
    {
        private int broj;
        private string naziv;

        public Mesec(int broj)
        {
            this.broj = broj;
            if (broj == 1) { naziv = "januar"; }
            else if (broj == 2) { naziv = "februar"; }
            else if (broj == 3) { naziv = "mart"; }
            else if (broj == 4) { naziv = "april"; }
            else if (broj == 5) { naziv = "maj"; }
            else if (broj == 6) { naziv = "jun"; }
            else if (broj == 7) { naziv = "jul"; }
            else if (broj == 8) { naziv = "avgust"; }
            else if (broj == 9) { naziv = "septembar"; }
            else if (broj == 10) { naziv = "oktobar"; }
            else if (broj == 11) { naziv = "novembar"; }
            else if (broj == 12) { naziv = "decembar"; }
            else
                naziv = "greska";
        }

        public Mesec() { this.broj = 0; naziv = ""; }
        public Mesec(int broj, string naziv) { this.broj = broj; this.naziv = naziv; }
        public int Broj { get { return broj; } set { broj = value; } }
        public string Naziv { get { return naziv; } set { naziv = value; } }
        public override string ToString()
        {
            return broj.ToString() + " " + naziv;
        }
    }

}
