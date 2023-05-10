using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Media_Bazaar
{
    public partial class ProductStatisticsForm : Form
    {
        Company company = new Company();
        Person person;
        public ProductStatisticsForm(Person person)
        {
            this.person = person;
            InitializeComponent();
            company.GetProducts();
            company.GenerateStockChangeList();
            lTotalSales.Text = company.CalculateTotalSales().ToString();
            lMostSoldProduct.Text = company.MostSoldStockId().ToString();
            lSalesToday.Text = company.TotalSalesToday().ToString();
        }

        private void ProductStatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void lMostSoldProduct_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bCheckSales_Click(object sender, EventArgs e)
        {
            lSalesSpecific.Text = "Result: " + company.TotalSalesSpecificPeriod(dtpStartDate.Value, dtpEndDate.Value).ToString();
        }
    }
}
