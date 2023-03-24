using DataManagement;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Management
    {
        SqlHelperG sqlHelper = new SqlHelperG();
        public void AddProduct(string name, Category category, string description)
        {
            sqlHelper.AddProduct(name, category.ToString(), description);
        }
        public void DeleteProduct(int id)
        {
            sqlHelper.DeleteProduct(id);
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
                sqlHelper.ChangeStockAmount(product.Id, amount);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
        public void CreateChange(int productId, int change, int isRestock)
        {
            sqlHelper.CreateChange(productId, DateTime.Now, change, isRestock);
        }
        public void ChangeStockAmount(int productId, int amount)
        {
            sqlHelper.ChangeStockAmount(productId, amount);
        }
    }
}
