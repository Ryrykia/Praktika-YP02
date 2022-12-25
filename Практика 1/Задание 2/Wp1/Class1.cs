using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wp1
{
    internal class Book
    {
        private int ID;
        private int amountOfPages;
        private double cost;
        private string type;

        public string Name;
        public string Publisher;
        public int yearOfPublish;
        public string Author;

        public Book() {}

        public Book(int id, string name, string author, string publisher, int year, int amount, double cost, string type)
        {
            this.ID = id;
            this.Name = name;
            this.Author = author;
            this.Publisher = publisher;
            this.yearOfPublish = year;
            this.amountOfPages = amount;
            this.cost = cost;
            this.type = type;
        }

        public override string ToString()
        {
            return Name + " " + Author + " " + Publisher + " " + yearOfPublish;
        }

    }
}
