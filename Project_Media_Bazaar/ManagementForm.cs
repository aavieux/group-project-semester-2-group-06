namespace Project_Media_Bazaar;
using Domain;

public partial class ManagementForm : Form
{

    Management manager = new Management();
    Company company = new Company();
    public ManagementForm(Person person)
    {
        InitializeComponent();
        RefreshListbox();
    }
    private void RefreshListbox()
    {
        company.FillProductsList();
        lvProducts.Items.Clear();
        foreach (Product product in company.GetProducts())
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

    private void bViewDetailsProduct_Click_1(object sender, EventArgs e)
    {

    }

    private void bAddProduct_Click_1(object sender, EventArgs e)
    {

    }

    private void bRemoveProduct_Click_1(object sender, EventArgs e)
    {

    }

    private void bRefreshProducts_Click_1(object sender, EventArgs e)
    {

    }

    private void bProductStatistics_Click_1(object sender, EventArgs e)
    {

    }

    private void bChangeStock_Click_1(object sender, EventArgs e)
    {

    }

    private void bViewDetailsProduct_Click(object sender, EventArgs e)
    {
        try
        {
            ProductInformation form = new ProductInformation(company.GetProducts()[lvProducts.FocusedItem.Index]);
            form.ShowDialog();
        }
        catch (NullReferenceException)
        {
            MessageBox.Show("No item selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void bAddProduct_Click(object sender, EventArgs e)
    {
        AddProduct form = new AddProduct(manager);
        form.ShowDialog();
    }

    private void bRemoveProduct_Click(object sender, EventArgs e)
    {
        try
        {
            company.DeleteProduct(company.GetProducts()[lvProducts.FocusedItem.Index]);
            RefreshListbox();
        }
        catch (NullReferenceException)
        {
            MessageBox.Show("No item selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void bChangeStock_Click(object sender, EventArgs e)
    {
        try
        {
            AmountChange amountChange = new AmountChange(company.GetProducts()[lvProducts.FocusedItem.Index], manager);
            amountChange.ShowDialog();
        }
        catch (NullReferenceException)
        {
            MessageBox.Show("No item selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void bRefreshProducts_Click(object sender, EventArgs e)
    {
        RefreshListbox();
    }

    private void bProductStatistics_Click(object sender, EventArgs e)
    {
        ProductStatisticsForm form = new ProductStatisticsForm();
        form.ShowDialog();
    }
}