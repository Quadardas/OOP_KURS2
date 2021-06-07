

namespace OOP_KURS2
{
    public class Services
    {
        string name; int price;

        public Services(string Name, int Price)
        {
            this.name = Name;
            this.price = Price;
        }
        public string thisServicesName
        {
            get { return this.name; }
            set { this.name = value is string ? value : null; }
        }
        public int thisPrice
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public virtual string display()
        {
            string text = $"Название {this.name}, Цена {this.price}";
            return text;
        }
    }
}
