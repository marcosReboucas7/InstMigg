using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstMigg.Models
{
    public class Installs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Contract { get; set; }
        public double Price { get; set; }

        public Installs(int id, string name, DateTime date, string contract, double price)
        {
            Id = id;
            Name = name;
            Date = date;
            Contract = contract;
            Price = price;
        }
        
    }
}