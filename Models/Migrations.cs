using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstMigg.Models
{
    public class Migrations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
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
    }
}