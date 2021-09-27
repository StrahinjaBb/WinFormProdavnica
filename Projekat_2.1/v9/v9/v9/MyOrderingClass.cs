using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v9
{
    public class MyOrderingClass : IComparer<Proizvod>
    {
        public int Compare(Proizvod x, Proizvod y)
        {
            int compareDate = x.Naziv.CompareTo(y.Naziv);
            if (compareDate == 0)
            {
                return x.IdProizvod.CompareTo(y.IdProizvod);
            }
            return compareDate;
        }
    }
}
