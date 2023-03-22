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
    public partial class AmountChange : Form
    {
        Product product;
        Management manager;
        public AmountChange(Product product, Management manager)
        {
            InitializeComponent();
            this.product = product;
            this.manager = manager;
        }

        private void changeStock_Click(object sender, EventArgs e)
        {
            string operation = changeType.Text;
            int amount = Convert.ToInt32(changingAmount.Value);
            if (manager.ChangeStockAmount(product, amount, operation))
            {
                changedStock.Text = product.Amount.ToString();
                if (operation.Equals("increase"))
                {
                    manager.CreateChange(product.Id, amount, 1);
                }
                if (operation.Equals("decrease"))
                {
                    manager.CreateChange(product.Id, amount, 0);
                }
                manager.ChangeStockAmount(product.Id, product.Amount);
            }
            else
            {
                MessageBox.Show("Wrong amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
