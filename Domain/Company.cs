using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataManagement;
using Domain.Enums;

namespace Domain
{
    public class Company
    {
        private List<Product> products = new List<Product>();
        private List<StockChange> stockChanges = new List<StockChange>();
        private List<int> seenProducts = new List<int>();
        private List<Person> people = new List<Person>();
        SqlHelperG sqlHelper = new SqlHelperG();

        public void GenerateProducts()
        {
            Product product;
            products.Clear();
            var table = sqlHelper.ReadProductsFromDB();
            foreach (DataRow dr in table.Rows)
            {

                products.Add(product = new Product((int)dr[0], (string)dr[1], (int)dr[2], (string)dr[3], (string)dr[4], (int)dr[5]));

            }
        }
        public List<Product> GetProducts()
        {
            GenerateProducts();
            return products;
        }
        public void DeleteProduct(Product product)
        {
            sqlHelper.DeleteProductFromDB(product.Id);

        }
        public List<StockChange> GenerateStockChangeList()
        {
            StockChange stockChange;
            stockChanges.Clear();
            DataTable table = sqlHelper.ReadStockChangesFromDB();
            foreach (DataRow dr in table.Rows)
            {
                stockChanges.Add(stockChange = new StockChange((int)dr[0], (int)dr[1], (DateTime)dr[2], (int)dr[3], (int)dr[4]));
            }
            return stockChanges;
        }
        public int CalculateTotalSales()
        {
            int totalSales = 0;
            foreach (StockChange stockChange in stockChanges)
            {
                if (!stockChange.IsRestock())
                    totalSales += stockChange.GetChangeAmount();
            }
            return totalSales;
        }
        public int TotalSalesToday()
        {
            int sales = 0;
            foreach(StockChange stockChange in stockChanges)
            {
                if(stockChange.GetDate().Day == DateTime.Today.Day)
                {
                    sales += stockChange.GetChangeAmount();
                }
            }
            return sales;
        }
        public int TotalSalesSpecificPeriod(DateTime Start, DateTime End)
        {
            int sales = 0;
            foreach(StockChange stockChange in stockChanges)
            {
                if(stockChange.GetDate().Day > Start.Day && stockChange.GetDate().Day < End.Day)
                {
                    sales += stockChange.GetChangeAmount();
                }
            }
            return sales;
        }
        private List<StockChange> GetSoldStocks()
        {
            List<StockChange> soldProducts = new List<StockChange>();
            foreach (StockChange stockChange in stockChanges)
            {
                if (!stockChange.IsRestock())
                {
                    soldProducts.Add(stockChange);
                }
            }
            return soldProducts;
        }

        public string MostSoldStockId()
        {
            List<StockChange> stockChanges = GetSoldStocks();
            IDictionary<int, int> sales = new Dictionary<int, int>();
            int soldAmount = 0;
            foreach (StockChange stockChange in stockChanges)
            {
                if (!seenProducts.Contains(stockChange.ProductId()))
                {
                    foreach (StockChange sameStock in stockChanges)
                    {
                        if (sameStock.ProductId() == stockChange.ProductId())
                        {
                            soldAmount += sameStock.GetChangeAmount();
                        }
                    }
                    sales[stockChange.ProductId()] = soldAmount;
                    soldAmount = 0;
                    seenProducts.Add(stockChange.ProductId());
                }
            }
            var mostSoldItem = sales.OrderByDescending(kvp => kvp.Value).ToDictionary(x => x.Key, x => x.Value).First();
            return GetProductById(mostSoldItem.Key).Name;
        }
        private Product GetProductById(int id)
        {
            foreach (Product product in products)
            {
                if (product.Id == id) return product;
            }
            return null;
        }

    }
}
