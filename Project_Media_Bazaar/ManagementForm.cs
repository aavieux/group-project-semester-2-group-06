namespace Project_Media_Bazaar;
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
        Company.GetProducts().Remove(Company.GetProducts()[lvProducts.FocusedItem.Index]);
        RefreshListbox();
    }

    private void bRefreshProducts_Click(object sender, EventArgs e)
    {
        RefreshListbox();
    }
    private void RefreshListbox()
    {
        Company.FillProductsList();
        lvProducts.Items.Clear();
        foreach (Product product in Company.GetProducts())
        {
            if (product.Amount > 50)
            {
                string[] row = { product.Name, product.Amount.ToString(), product.Category.ToString() };
                lvProducts.Items.Add(product.Id.ToString()).SubItems.AddRange(row);
                lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.Green;

            }
            else
            {
                string[] row = { product.Name, product.Amount.ToString(), product.Category.ToString() };
                lvProducts.Items.Add(product.Id.ToString()).SubItems.AddRange(row);
                lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.Red;
                //lvProducts.Items.Add($"{product.Name} | Amount: {product.Amount} | Category: {product.Category.ToString()}");
                //lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.Red;
            }


        }
    }

    private void bProductStatistics_Click(object sender, EventArgs e)
    {
        ProductStatisticsForm form = new ProductStatisticsForm();
        form.ShowDialog();
    }

    private void bViewDetailsProduct_Click(object sender, EventArgs e)
    {
        ProductInformation form = new ProductInformation(Company.GetProducts()[lvProducts.FocusedItem.Index]);
        form.ShowDialog();
    }

    private void bChangeStock_Click(object sender, EventArgs e)
    {
        AmountChange amountChange = new AmountChange(Company.GetProducts()[lvProducts.FocusedItem.Index], manager);
        amountChange.ShowDialog();
    }
}