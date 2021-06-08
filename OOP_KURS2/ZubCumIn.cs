using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    [Serializable]
    public class ZubCumIn : Cosmetic
    {
        string UdalType;
        public ZubCumIn(string UdalType, string cosmeticType, string name, int price) : base(cosmeticType, name, price)
        {
            this.UdalType = UdalType;
        }
        public string thisUdalType
        {
            get { return this.UdalType; }
            set { this.UdalType = value is string ? value : null; }
        }
    }
}
