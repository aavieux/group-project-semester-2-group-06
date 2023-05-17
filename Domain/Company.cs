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
            GenerateStockChangeList();
            int sales = 0;
            foreach(StockChange stockChange in stockChanges)
            {
                if(stockChange.GetDate() >= Start && stockChange.GetDate() <= End)
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
        public DateTime GetSpecificMonthDate(string month)
        {
            System.DateTime moment;
            switch (month) 
            {
                case "January":
                    return moment = new System.DateTime(DateTime.Now.Year, 1, 15);
                case "February":
                    return moment = new System.DateTime(DateTime.Now.Year, 2, 15);
                case "March":
                    return moment = new System.DateTime(DateTime.Now.Year, 3, 15);
                case "April":
                    return moment = new System.DateTime(DateTime.Now.Year, 4, 15);
                case "May":
                    return moment = new System.DateTime(DateTime.Now.Year, 5, 15);
                case "June":
                    return moment = new System.DateTime(DateTime.Now.Year, 6, 15);
                case "July":
                    return moment = new System.DateTime(DateTime.Now.Year, 7, 15);
                case "August":
                    return moment = new System.DateTime(DateTime.Now.Year, 8, 15);
                case "September":
                    return moment = new System.DateTime(DateTime.Now.Year, 9, 15);
                case "October":
                    return moment = new System.DateTime(DateTime.Now.Year, 10, 15);
                case "November":
                    return moment = new System.DateTime(DateTime.Now.Year, 11, 15);
                case "December":
                    return moment = new System.DateTime(DateTime.Now.Year, 12, 15);
                default: return DateTime.Today;
            }
        }
    }
}
