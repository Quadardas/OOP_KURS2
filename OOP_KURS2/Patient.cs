using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    public class Patient : Human
    {
        string Diagnoz, Pass; // pass это паспорт
        List<Services> RequestedServices = new List<Services>();

        public Patient(string Diagnoz,string Pass, string name, string age) : base(age, name)
        {
            this.Diagnoz = Diagnoz;
            this.Pass = Pass;
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
