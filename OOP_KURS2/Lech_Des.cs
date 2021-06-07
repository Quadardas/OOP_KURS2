using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    public class Lech_Des : Therapy
    {
        List<string> DESNs = new List<string>();

        public Lech_Des(string name, int price, string type) : base(type, name, price)
        {
        }

        public List<string> thisDESNs
        {
            get { return DESNs; }

        }
        public string setThisDESNs
        {
            set { DESNs.Add(value); }
        }
    }
}
