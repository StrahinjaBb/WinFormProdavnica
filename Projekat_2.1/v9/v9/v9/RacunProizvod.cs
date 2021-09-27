using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v9
{
    public class RacunProizvod
    {
        private int idRacun;
        private int idProizvod;
        private int kolicina;

        public RacunProizvod(int idRacun, int idProizvod, int kolicina)
        {
            this.idProizvod = idProizvod;
            this.idRacun = idRacun;
            this.kolicina = kolicina;
        }

        public RacunProizvod()
        {
            this.idRacun = 0;
            this.idProizvod = 0;
            this.kolicina = 0;
        }

        public int IdRacun
        {
            get { return idRacun; }
            set { idRacun = value; }
        }

        public int IdProizvod
        {
            get { return idProizvod; }
            set { idProizvod = value; }
        }

        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }

        public void izmeniKolicinu(int x) { this.kolicina += x; }

        public override string ToString()
        {
            return idRacun.ToString() + " " + idProizvod.ToString() + " " + kolicina.ToString();
        }
    }
}
