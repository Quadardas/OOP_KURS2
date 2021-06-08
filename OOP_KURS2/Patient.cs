using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    [Serializable]
    public class Patient : Human
    {
        string Diagnoz, Pass, toHeal, type, doctor; // pass это паспорт
        List<Services> RequestedServices = new List<Services>();

        public Patient(string toHeal, string Diagnoz,string Pass, string name, string age, string type, string doctor) : base(age, name)
        {
            this.Diagnoz = Diagnoz;
            this.Pass = Pass;
            this.toHeal = toHeal;
            this.type = type;
            this.doctor = doctor;
        }

        public string thisDoc
        {
            get { return this.doctor; }
            set { this.doctor = value is string ? value : null; }
        }

        public string thisType
        {
            get { return this.type; }
            set { this.type = value is string ? value : null; }
        }

        public string thisToHeal
        {
            get { return this.toHeal; }
            set { this.toHeal = value is string ? value : null; }
        }

        public string thisDiagnoz
        {
            get { return this.Diagnoz; }
            set { this.Diagnoz = value is string ? value : null; }
        }
        public string thisPass
        {
            get { return this.Pass; }
            set { this.Pass = value is string ? value : null; }
        }
        public List<Services> thisService
        {
            get { return RequestedServices; }

        }
        public Services setThisService
        {
            set { RequestedServices.Add(value); }
        }
    }
}
