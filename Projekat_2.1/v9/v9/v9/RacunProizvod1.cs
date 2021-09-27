using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v9
{
    public class RacunProizvod1
    {
        private Racun r;
        private Proizvod p;
        private int kolicina;

        public RacunProizvod1(Racun r, Proizvod p, int kolicina)
        {
            this.r = r;
            this.p = p;
            this.kolicina = kolicina;
        }

        public int getIdProizvoda()
        {
            return this.p.IdProizvod;
        }

        public double getCenaProizvoda() { return p.Cena; }
        public int getKolicina() { return this.kolicina; }

        public override string ToString()
        {
            return p.Naziv + " " + kolicina.ToString();
        }
    }
}
