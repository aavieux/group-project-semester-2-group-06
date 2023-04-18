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
            company.FillProductsList(person.Department);
            company.FillStockChangesList();
            lTotalSales.Text = company.CalculateTotalSales().ToString();
            lMostSoldProduct.Text = company.MostSoldStockId().ToString();
        }

        private void ProductStatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void lMostSoldProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
