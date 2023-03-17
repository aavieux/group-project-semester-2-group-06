using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Amount { get; private set; }
        public Category Category { get; private set; }
        public string Description { get; private set; }
        public Product(int id, string name, int amount, string category, string description) {
            Id = id;
            Name = name;
            Amount = amount;
            Category = Enum.Parse<Category>(category);
            Description = description;
        }
    }
}
