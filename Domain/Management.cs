using DataManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
            sql.DeleteProduct(id);
        }
        public bool ChangeStockAmount(Product product, int amount, string operation) 
        {
            try
            {
                if (operation.Equals("increase"))
                {
                    product.changeAmount(product.Amount + amount);
                    
                }
                if (operation.Equals("decrease"))
                {
                    product.changeAmount(product.Amount - amount);
                }
                sql.ChangeStockAmount(product.Id, amount);
            }
            catch(ArgumentException) {
                return false;
            }
            return true;
        }
        public void CreateChange(int productId, int change, int isRestock)
        {
            sql.CreateChange(productId, DateTime.Now, change, isRestock);
        }
        public void ChangeStockAmount(int productId, int amount)
        {
            sql.ChangeStockAmount(productId, amount);
        }
    }
}
