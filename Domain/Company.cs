using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataManagement;

namespace Domain
{
    public static class Company
    {
        private static List<Product> products = new List<Product>();
        public static void FillProductsList()
        {
            SqlHelperG sql = new SqlHelperG();
            Product product;
            products.Clear();
            var table = sql.ReadProducts();
            foreach (DataRow dr in table.Rows)
            {
                products.Add(product = new Product((int)dr[0], (string)dr[1], (int)dr[2], (string)dr[3], (string)dr[4]));
            }
        }
        public static List<Product> GetProducts()
        {
            return products;
        }
        public static void DeleteProduct(Product product)
        {
            SqlHelperG sql = new SqlHelperG();
            sql.DeleteProduct(product.Id);
        }
    }
}
