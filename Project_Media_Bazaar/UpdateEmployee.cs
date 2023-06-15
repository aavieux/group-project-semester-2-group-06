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
    public partial class UpdateEmployee : Form
    {
        DataAccessEmployeeDashboard dataAccessEmployeeDashboard;
		private Employee chosenEmployee;
		private int chosenEmployeeId;
		public UpdateEmployee(int chosenEmployeeid)
        {
            this.dataAccessEmployeeDashboard = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
			this.chosenEmployeeId = chosenEmployeeid;
            InitializeComponent();
			LoadData();

        }
		private void LoadData()
		{
			this.chosenEmployee = dataAccessEmployeeDashboard.GetEmployeeByIdFromDB(chosenEmployeeId);

			tbFirstName.Enabled = false;
			tbLastName.Enabled = false;
			tbPhone.Enabled = false;
			birthDate_dtp.Enabled = false;
			tbEmail.Enabled = false;
			tbAddress.Enabled = false;
			tbSalary.Enabled = false;
			tbWorkingHours.Enabled = false;

			tbFirstName.Text = chosenEmployee.firstName;
			tbLastName.Text = chosenEmployee.lastName;
			tbPhone.Text = chosenEmployee.phoneNumber;
			tbEmail.Text = chosenEmployee.email;
			tbAddress.Text = chosenEmployee.address;
			tbSalary.Text = chosenEmployee.salary.ToString();
			tbWorkingHours.Text = chosenEmployee.workingHours.ToString();

		}
		private void btnSave_Click(object sender, EventArgs e)
        {
			try
			{
				Employee saveEmployee = new Employee(chosenEmployee.id, tbFirstName.Text, tbLastName.Text, tbPhone.Text, birthDate_dtp.Value, tbAddress.Text, decimal.Parse(tbSalary.Text), tbEmail.Text, int.Parse(tbWorkingHours.Text));
            
				if (dataAccessEmployeeDashboard.UpdateEmployeeToDB(saveEmployee))
				{
				}
				else
				{
					MessageBox.Show("Something went wrong!");
        }

			}
			catch (Exception)
			{
				MessageBox.Show("Error saving info!");
			}
			finally
			{
				LoadData();
				btnSave.Visible = false;
				update_btn.Visible = true;
				delete_btn.Visible = true;
			}
		}

		private void update_btn_Click(object sender, EventArgs e)
        {
			update_btn.Visible = false;
			delete_btn.Visible = false;

			btnSave.Visible = true;

			tbFirstName.Enabled = true;
			tbLastName.Enabled = true;
			tbPhone.Enabled = true;
			birthDate_dtp.Enabled = true;
			tbEmail.Enabled = true;
			tbAddress.Enabled = true;
			tbSalary.Enabled = true;
			tbWorkingHours.Enabled = true;
		}
		private void delete_btn_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataAccessEmployeeDashboard.DeleteEmployeeByIdFromDB(chosenEmployee.id))
				{
					MessageBox.Show("Succesfully deleted employee!");
					this.Close();
				}
				else
				{
					MessageBox.Show("Error deleting employee!");
				}
			}
			catch (Exception)
			{

			}
			finally
			{
				
			}

		}

		private void UpdateEmployee_Load(object sender, EventArgs e)
		{

        }

        private void update_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          

            btnSave.Text = "";

            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhone.Text = "";
            birthDate_dtp.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbSalary.Text = "";
            tbWorkingHours.Text = "";
			this.Close();
        }
    }
}
