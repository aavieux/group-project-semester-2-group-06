﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Domain.Enums;

namespace Project_Media_Bazaar
{
    public partial class AddProduct : Form
    {
        Management manager;
        ManagementForm mForm;
        public AddProduct(Management manager, ManagementForm mForm)
        {
            InitializeComponent();
            this.mForm = mForm;
            this.manager = manager;
        }

        private void bAddProduct_Click_1(object sender, EventArgs e)
        {

        }

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            manager.AddProduct(tbName.Text, (Department)cbProductCategory.SelectedIndex, tbDescription.Text, Convert.ToInt32(numThreshold.Value));
            mForm.RefreshListbox();
            this.Close();
        }
    }
}
