using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KURS2
{
    [Serializable]
    public class Human
    {
        string Age, Name;

        public Human(string Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;

        }
        public string thisAge
        {
            get { return this.Age; }
            set { this.Age = value is string ? value : null; }
        }
        public string thisName
        {
            get { return this.Name; }
            set { this.Name = value is string ? value : null; }
        }
    }

}
