﻿using Domain;
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
        ManagementForm mForm;
        public AmountChange(Product product, Management manager, ManagementForm mForm)
        {
            InitializeComponent();
            this.product = product;
            this.manager = manager;
            this.mForm = mForm;
        }

        private void changeStock_Click(object sender, EventArgs e)
        {
            string operation;
            if (rbIncrease.Checked)
            {
                operation = "increase";
                ChangeStock(product, Convert.ToInt32(changingAmount.Value), operation);
            }
            else if (rbDecrease.Checked)
            {
                operation = "decrease";
                ChangeStock(product, Convert.ToInt32(changingAmount.Value), operation);
            }
            else
            {
                MessageBox.Show("Choose a type of operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ChangeStock(Product product, int amount, string operation)
        {
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
                mForm.RefreshListbox();
            }
            else
            {
                MessageBox.Show("Wrong amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mForm.RefreshListbox();
            }
        }

        private void AmountChange_Load(object sender, EventArgs e)
        {

        }
    }
}
