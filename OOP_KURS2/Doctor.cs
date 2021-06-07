using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    public class Doctor : Human
    {
        string Stazh, Education;
        List<Services> ThisDoctorServices = new List<Services>();

        public Doctor(string Stazh, string Education, string name, string age) : base(age, name)
        {
            this.Stazh = Stazh;
            this.Education = Education;
        }
        public string thisStazh
        {
            get { return this.Stazh; }
            set { this.Stazh = value is string ? value : null; }
        }
        public string thisEducation
        {
            get { return this.Education; }
            set { this.Education = value is string ? value : null; }
        }
        public List<Services> thisService
        {
            get { return ThisDoctorServices; }
        }
        public Services setThisService
        {
            set { ThisDoctorServices.Add(value); }
        }
    }

}
