using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v9
{
    public class Racun
    {
        private int idRacun;
        private double cenaUkupno;
        private DateTime datum;

        public Racun()
        {
            this.idRacun = 0;
            this.cenaUkupno = 0;
            this.datum = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }

        public Racun(int godina, int mesec, int dan, int sat, int minut, int sekund)
        {
            this.idRacun = 0;
            this.cenaUkupno = 0;
            this.datum = new DateTime(godina, mesec, dan, sat, minut, sekund);
        }

        public int IdRacun
        {
            get { return idRacun; }
            set { idRacun = value; }
        }

        public void setDatumVreme(int dan, int mesec, int godina, int sat, int minut, int sekunda)
        {
            this.datum = new DateTime(godina, mesec, dan, sat, minut, sekunda);
        }

        public double CenaUkupno
        {
            get { return cenaUkupno; }
            set { cenaUkupno = value; }
        }

        public DateTime DatumVreme
        {
            get { return datum; }
            set { datum = value; }
        }

        public void izmeniCenu(double tmp)
        {
            this.cenaUkupno += tmp;
        }

        public override string ToString()
        {
            return idRacun.ToString() + " " + cenaUkupno.ToString() + " " + datum.ToString();
        }
    }
}
