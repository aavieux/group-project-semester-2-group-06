namespace Project_Media_Bazaar;

using DataManagement;
using Domain;

public partial class ManagementForm : Form
{
    Management manager = new Management();
    public ManagementForm()
    {
        InitializeComponent();
        RefreshListbox();
    }

    private void bAddProduct_Click(object sender, EventArgs e)
    {
        AddProduct form = new AddProduct(manager);
        form.ShowDialog();
    }

    private void bRemoveProduct_Click(object sender, EventArgs e)
    {
        Company.DeleteProduct(Company.GetProducts()[lbProducts.SelectedIndex]);
        RefreshListbox();
    }

    private void bRefreshProducts_Click(object sender, EventArgs e)
    {
        RefreshListbox();
    }
    private void RefreshListbox()
    {
        Company.FillProductsList();
        lbProducts.Items.Clear();

        foreach (Product product in Company.GetProducts())
        {
            lbProducts.Items.Add($"{product.Name} | Amount: {product.Amount} | Category: {product.Category.ToString()}");
        }
    }

    private void bProductStatistics_Click(object sender, EventArgs e)
    {
        ProductStatisticsForm form = new ProductStatisticsForm();
        form.ShowDialog();
    }
}