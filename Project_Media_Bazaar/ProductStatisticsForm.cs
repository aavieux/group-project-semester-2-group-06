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
            ShowGroupBoxWithItems(groupBox);
            company.GetProducts();
            company.GenerateStockChangeList();
            lTotalSales.Text = company.CalculateTotalSales().ToString();
            lMostSoldProduct.Text = company.MostSoldStockId().ToString();
            lSalesToday.Text = company.TotalSalesToday().ToString();
        }
        private void HideGroupBoxWithItems(GroupBox groupBox)
        {
            groupBox.Visible = false;
            oneWeek_btn.Visible = false;
            oneMonth_btn.Visible = false;
            oneYear_btn.Visible = false;
            custom_btn.Visible = false;

            from_lbl.Visible = true;
            until_lbl.Visible = true;
            dtpStartDate.Visible = true;
            dtpEndDate.Visible = true;

            x_btn.Visible = true;
            generate_btn.Visible = true;
        }

        private void ShowGroupBoxWithItems(GroupBox groupBox)
        {
            groupBox.Visible = true;
            oneWeek_btn.Visible = true;
            oneMonth_btn.Visible = true;
            oneYear_btn.Visible = true;
            custom_btn.Visible = true;

            from_lbl.Visible = false;
            until_lbl.Visible = false;
            dtpStartDate.Visible = false;
            dtpEndDate.Visible = false;

            x_btn.Visible = false;
            generate_btn.Visible = false;
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
            result_lbl.Text = "Result: " + company.TotalSalesSpecificPeriod(dtpStartDate.Value, dtpEndDate.Value).ToString();
        }

        private void custom_btn_Click(object sender, EventArgs e)
        {
            HideGroupBoxWithItems(groupBox);
        }

        private void x_btn_Click(object sender, EventArgs e)
        {
            ShowGroupBoxWithItems(groupBox);
        }

        private void oneWeek_btn_Click(object sender, EventArgs e)
        {
            result_lbl.Text = "Result: " + company.TotalSalesSpecificPeriod(DateTime.Now.AddDays(-7), DateTime.Now).ToString();
        }

        private void oneMonth_btn_Click(object sender, EventArgs e)
        {
            result_lbl.Text = "Result: " + company.TotalSalesSpecificPeriod(DateTime.Now.AddDays(-30), DateTime.Now).ToString();
        }

        private void oneYear_btn_Click(object sender, EventArgs e)
        {
            result_lbl.Text = "Result: " + company.TotalSalesSpecificPeriod(DateTime.Now.AddDays(-365), DateTime.Now).ToString();
        }
    }
}
