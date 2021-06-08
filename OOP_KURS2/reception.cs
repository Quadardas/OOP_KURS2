using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    [Serializable]
    public class reception
    {
        string Date, PatientName, DoctorName, ServiceType;
        public reception(string Date, string PatientName, string DoctorName, string ServiceType)
        { 
            this.Date = Date;
            this.PatientName = PatientName;
            this.DoctorName = DoctorName;
            this.ServiceType = ServiceType;
        }
        public string thisPatientName
        {
            get { return this.PatientName; }
            set { this.PatientName = value is string ? value : null; }
        }
        public string thisDate
        {
            get { return this.Date; }
            set { this.Date = value is string ? value : null; }
        }
        public string thisDoctorName
        {
            get { return this.DoctorName; }
            set { this.DoctorName = value is string ? value : null; }
        }
        public string thisServiceType
        {
            get { return this.ServiceType; }
            set { this.ServiceType = value is string ? value : null; }
        }
    }
}
