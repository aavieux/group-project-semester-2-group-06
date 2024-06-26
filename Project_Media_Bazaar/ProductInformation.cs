using Domain;
namespace Project_Media_Bazaar
{
    public partial class ProductInformation : Form
    {
        public ProductInformation()
        {
            InitializeComponent();

        }
        public ProductInformation(Product ourProduct)
        {
            InitializeComponent();
            showName.Text = "Name: " + ourProduct.Name;
            showAmount.Text = "Amount: " + ourProduct.Amount.ToString();
            showDescription.Text = "Description: " + ourProduct.Description;
            showCategory.Text = "Category: " + ourProduct.Category.ToString();
            showThreshold.Text = "Threshold: " + ourProduct.Threshold.ToString();
        }

        private void ProductInformation_Load(object sender, EventArgs e)
        {

        }
    }
}