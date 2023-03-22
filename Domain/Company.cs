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
    public class Company
    {
        private List<Product> products = new List<Product>();
        private List<StockChange> stockChanges = new List<StockChange>();
        private List<int> seenProducts = new List<int>();
        public void FillProductsList()
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
        public List<Product> GetProducts()
        {
            return products;
        }
        public void DeleteProduct(Product product)
        {
            SqlHelperG sql = new SqlHelperG();
            sql.DeleteProduct(product.Id);

        }
        public List<StockChange> FillStockChangesList()
        {
            SqlHelperG sql = new SqlHelperG();
            StockChange stockChange;
            stockChanges.Clear();
            DataTable table = sql.ReadStockChanges();
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
            foreach(StockChange stockChange in stockChanges)
            {
                if (!seenProducts.Contains(stockChange.ProductId()))
                {
                    foreach(StockChange sameStock in stockChanges)
                    {
                        if(sameStock.ProductId() == stockChange.ProductId())
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
            foreach(Product product in products)
            {
                if(product.Id == id) return product;
            }
            return null;
        }
    }
}
