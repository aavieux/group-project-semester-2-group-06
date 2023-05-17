using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public Department Category { get; private set; }
        public string Description { get; private set; }
        public int Threshold { get; private set; }

        public Product(int id, string name, int amount, string category, string description, int threshold) {
            Id = id;
            Name = name;
            Amount = amount;
            Category = Enum.Parse<Department>(category);
            Description = description;
            Threshold = threshold;
        }
        public void changeAmount(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                Amount = amount;
            }
        }
    }
}
