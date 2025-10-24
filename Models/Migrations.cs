namespace InstMigg.Models
{
    public class Migrations : Client
    {
        public string NewContract { get; set; }
        public double NewPrice { get; set; }

        public Migrations(int id, string name, DateTime date, string newContract, double newPrice)
        {
            Id = id;
            Name = name;
            Date = date;
            NewContract = newContract;
            NewPrice = newPrice;
        }

        public Migrations(){}

    }
}