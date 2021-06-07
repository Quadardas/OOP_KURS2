using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    public class Otbel : Cosmetic
    {
        string OtbelType;
        public Otbel(string otbelType, string cosmeticType, string name, int price) : base(cosmeticType, name, price)
        {
            this.OtbelType = otbelType;
        }
        public string thisOtbelType
        {
            get { return this.OtbelType; }
            set { this.OtbelType = value is string ? value : null; }
        }
    }
}
