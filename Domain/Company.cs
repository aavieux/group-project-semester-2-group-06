<<<<<<< HEAD
﻿using DataManagement;
using System;
using System.Collections.Generic;
using System.Data;
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
>>>>>>> 7465f7d20ddbe970773f4e3e1e633f8e12700d67
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
<<<<<<< HEAD
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
=======
    public class Company
    {
        public List<Product> products { get; private set; }
        public Company()
        {
            products = new List<Product>();
        }
        public Product? findProductById(int id)
        {
            foreach(Product product in products)
            {
                if(product.Id == id)
                {
                    return product;
                }
            }
            return null;
>>>>>>> 7465f7d20ddbe970773f4e3e1e633f8e12700d67
        }
    }
}
