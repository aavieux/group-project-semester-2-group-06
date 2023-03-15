using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
namespace Project_Media_Bazaar
{
    public partial class AddProduct : Form
    {
        Management manager;
        public AddProduct(Management manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            manager.AddProduct(tbName.Text, (Category)cbProductCategory.SelectedIndex, tbDescription.Text);
            this.Close();
        }
    }
}
