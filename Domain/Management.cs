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

        //Manage Products
        public void AddProduct(string name, Category category, string description, int threshold)
        {
            sqlHelper.AddProductToDB(name, category.ToString(), description, threshold);
        }
        public void DeleteProduct(int id)
        {
            sqlHelper.DeleteProductFromDB(id);
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

                sqlHelper.ChangeStockAmountFromDB(product.Id, amount);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
        public void CreateChange(int productId, int change, int isRestock)
        {
            sqlHelper.CreateChangeToDB(productId, DateTime.Now, change, isRestock);
        }
        public void ChangeStockAmount(int productId, int amount)
        {
            sqlHelper.ChangeStockAmountFromDB(productId, amount);
        }
    }
}
