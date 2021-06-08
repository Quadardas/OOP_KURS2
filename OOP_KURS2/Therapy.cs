using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    [Serializable]
    public class Therapy : Services
    {
        string therapyType;
        public Therapy(string therapyType, string name, int price) : base(name, price)
        {
            this.therapyType = therapyType;
        }
        public string thisTherapyType
        {
            get { return this.therapyType; }
            set { this.therapyType = value is string ? value : null; }
        }
        public override string display()
        {
            string text = $"Тип терапии {this.therapyType}";
            return text;
        }
    }
}
