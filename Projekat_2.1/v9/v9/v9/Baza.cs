using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace v9
{
    public class Baza
    {
        private OleDbConnection con;

        public Baza()
        {
            con = new OleDbConnection();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Straja\Desktop\VISER\semestar4\TVP\Projekat_2.1\Prodavnica1.2.accdb";
        }

        public Baza(string conStr)
        {
            con = new OleDbConnection();
            con.ConnectionString = conStr;
        }

        public OleDbConnection Con
        {
            get { return con; }
            set { con = value; }
        }

        public void otvoriKonekciju()
        {
            if (con != null)
                this.con.Open();
        }

        public void zatvoriKonekciju()
        {
            if (con != null)
                this.con.Close();
        }
    }
}
