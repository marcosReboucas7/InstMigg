namespace InstMigg.Models
{
    public class Installs : Client
    {

        public Installs(int id, string name, DateTime date, string contract, double price)
        {
            Id = id;
            Name = name;
            Date = date;
            Contract = contract;
            Price = price;
        }

        public Installs(){}
    }
}