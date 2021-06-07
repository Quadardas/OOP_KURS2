using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    public class UdalZuba : Surgery
    {
        List<int> ZUBs = new List<int>();

        public UdalZuba(string name, int price, string type) : base(type, name, price)
        {

        }

        public List<int> thisZUBs
        {
            get { return ZUBs; }

        }
        public int setThisZUBs
        {
            set { ZUBs.Add(value); }
        }
    }
}
