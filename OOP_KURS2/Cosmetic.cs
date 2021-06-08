using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    [Serializable]
    public class Cosmetic : Services
    {
        string CosmeticType;

        public Cosmetic(string cosmeticType, string name, int price) : base(name, price)
        {
            this.CosmeticType = cosmeticType;
        }
        public string thisCosmeticType
        {
            get { return this.CosmeticType; }
            set { this.CosmeticType = value is string ? value : null; }
        }
        
    }
}
