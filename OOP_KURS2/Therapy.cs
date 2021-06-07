

namespace OOP_KURS2
{
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
            string text = $"тип терапии {this.therapyType}";
            return text;
        }
    }
}
