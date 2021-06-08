using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    [Serializable]
    public class Surgery : Services
    {
        string SurgeryType;
        public Surgery(string surgeryType, string name, int price) : base(name, price)
        {
            this.SurgeryType = surgeryType;
        }
        public string thisSurgeryType
        {
            get { return this.SurgeryType; }
            set { this.SurgeryType = value is string ? value : null; }
        }
    }
}
