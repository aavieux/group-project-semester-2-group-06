namespace Project_Media_Bazaar;
using Domain;
using Domain.Enums;
using System.Xml.Linq;

public partial class ManagementForm : Form
{

    Management manager = new Management();
    Company company = new Company();
    Person person;
    LoginRegister loginRegister;
    public ManagementForm(Person person, LoginRegister loginForm)
    {
        loginRegister = loginForm;
        InitializeComponent();
        this.person = person;
        this.Text = $"Logged as: {person.firstName} {person.lastName} (Manager)";
        RefreshListbox();
        cbCategories.DataSource = Enum.GetValues(typeof(Department));

    }
    public void RefreshListbox()
    {
        company.GetProducts();
        lvProducts.Items.Clear();
        foreach (Product product in company.GetProducts())
        {
            if (product.Amount > product.Threshold)
            {
                //string[] row = { product.Name, product.Amount.ToString(), product.Category.ToString(), "OK" };
                lvProducts.Items.Add(product.Id.ToString());
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems.Add(product.Name);
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems.Add(product.Amount.ToString());
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems.Add(product.Category.ToString());
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems.Add("OK");
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems[0].BackColor = Color.DarkGreen;
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems[0].ForeColor = Color.White;

            }
            else
            {
                //string[] row = { product.Name, product.Amount.ToString(), product.Category.ToString(), "!" };
                lvProducts.Items.Add(product.Id.ToString());
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems.Add(product.Name);
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems.Add(product.Amount.ToString());
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems.Add(product.Category.ToString());
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems.Add("!");
                lvProducts.Items[lvProducts.Items.Count - 1].SubItems[0].BackColor = Color.Firebrick;
                //lvProducts.Items.Add($"{product.Name} | Amount: {product.Amount} | Category: {product.Category.ToString()}");
                //lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.Red;
            }


        }
    }

    private void bProductStatistics_Click(object sender, EventArgs e)
    {
        ProductStatisticsForm form = new ProductStatisticsForm(this.person);
        form.ShowDialog();
    }

    private void tbF_TextChanged(object sender, EventArgs e)
    {
        try
        {
            lvProducts.Items.Clear();
            string search = tbF.Text;
            foreach (Product product in company.GetProducts())
            {
                if (product.Name.ToUpper().Contains(search.ToUpper()))
                {

                    if (product.Amount > product.Threshold)
                    {
                        string[] row = { product.Name, product.Amount.ToString(), product.Category.ToString() };
                        lvProducts.Items.Add(product.Id.ToString()).SubItems.AddRange(row);
                        lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.DarkGreen;
                        lvProducts.Items[lvProducts.Items.Count - 1].SubItems[0].ForeColor = Color.White;

                    }
                    else
                    {
                        string[] row = { product.Name, product.Amount.ToString(), product.Category.ToString() };
                        lvProducts.Items.Add(product.Id.ToString()).SubItems.AddRange(row);
                        lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.Firebrick;
                        //lvProducts.Items.Add($"{product.Name} | Amount: {product.Amount} | Category: {product.Category.ToString()}");
                        //lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.Red;
                    }



                }
            }
        }
        catch (Exception) { }


    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void btnTasks_Click(object sender, EventArgs e)
    {
        TaskManager taskManager = new TaskManager();
        taskManager.ShowDialog();

    }

    private void bAddProduct_Click_2(object sender, EventArgs e)
    {

        AddProduct form = new AddProduct(manager, this);
        form.ShowDialog();
    }

    private void bRemoveProduct_Click_2(object sender, EventArgs e)
    {
        try
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item ?",
                                     "Confirm Delete!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                company.DeleteProduct(company.GetProducts()[lvProducts.FocusedItem.Index]);
                RefreshListbox();
            }
        }
        catch (NullReferenceException)
        {
            MessageBox.Show("No item selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void bViewDetailsProduct_Click_2(object sender, EventArgs e)
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

    private void bChangeStock_Click_2(object sender, EventArgs e)
    {
        try
        {
            AmountChange amountChange = new AmountChange(company.GetProducts()[lvProducts.FocusedItem.Index], manager, this);
            amountChange.ShowDialog();
        }
        catch (NullReferenceException)
        {
            MessageBox.Show("No item selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void bRefreshProducts_Click_2(object sender, EventArgs e)
    {
        RefreshListbox();
    }

    private void bProductStatistics_Click_2(object sender, EventArgs e)
    {
        ProductStatisticsForm form = new ProductStatisticsForm(this.person);
        form.ShowDialog();
    }

    private void bLogout_Click(object sender, EventArgs e)
    {
        this.Close();

    }

    private void bShowAllAgain_Click(object sender, EventArgs e)
    {
        cbCategories.SelectedItem = null;
        RefreshListbox();
    }

    private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnEmployeeShiftsView_Click(object sender, EventArgs e)
    {
    }

    private void btnAssignShift_Click(object sender, EventArgs e)
    {
        AssignShiftAutomatic assignShiftAutomatic = new AssignShiftAutomatic();
        assignShiftAutomatic.ShowDialog();
    }

    private void btnEmployeeShiftsView_Click_1(object sender, EventArgs e)
    {

        EmployeeShiftsView employeeShiftsView = new EmployeeShiftsView();
        employeeShiftsView.ShowDialog();
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        string selectedCategory;
        try
        {
            selectedCategory = cbCategories.SelectedItem.ToString();

            lvProducts.Items.Clear();


            foreach (Product product in company.GetProducts())
            {
                if (product.Category.ToString().Contains(selectedCategory))
                {

                    if (product.Amount > product.Threshold)
                    {
                        string[] row = { product.Name, product.Amount.ToString(), product.Category.ToString() };
                        lvProducts.Items.Add(product.Id.ToString()).SubItems.AddRange(row);
                        lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.DarkGreen;

                    }
                    else
                    {
                        string[] row = { product.Name, product.Amount.ToString(), product.Category.ToString() };
                        lvProducts.Items.Add(product.Id.ToString()).SubItems.AddRange(row);
                        lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.Firebrick;

                        //lvProducts.Items.Add($"{product.Name} | Amount: {product.Amount} | Category: {product.Category.ToString()}");
                        //lvProducts.Items[lvProducts.Items.Count - 1].BackColor = Color.Red;
                    }





                }
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Invalid filter", "Error");
        }
    }
}