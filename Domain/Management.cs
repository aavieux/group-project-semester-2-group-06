using DataManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain
{
    public class Management
    {
        SqlHelperG sql = new SqlHelperG();
        public void AddProduct(string name, Category category, string description)
        {
            sql.AddProduct(name, category.ToString(), description);
        }
        public void DeleteProduct(int id)
        {

        }
        public void ReduceStock(int id, int amount) 
        {

        }
        public void IncreaseStock(int id, int amount) 
        {

        }
    }
}
