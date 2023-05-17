using DataManagement;
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
    public partial class SelectEmployees : Form
    {
        List<Employee> selectedEmployees;
        DataAccessEmployeeDashboard dataAccessEmployeeDashboard;
        public SelectEmployees(List<Employee> selectedEmployees)
        {
            dataAccessEmployeeDashboard = new DataAccessEmployeeDashboard("Server=mssqlstud.fhict.local;Database=dbi501511_bazaar;User Id=dbi501511_Bazaar;Password=Samocska;");
            this.selectedEmployees = selectedEmployees;

            InitializeComponent();
            GenerateDaata();
        }
        private void GenerateDaata()
        {
           
            List<Employee> toBeSelected = dataAccessEmployeeDashboard.GetAllUsersFromDB();
            
            foreach (Employee emp in toBeSelected.ToList())
            {
                foreach (Employee emp2 in selectedEmployees)
                {
                    if (emp.id == emp2.id)
                    {
                        toBeSelected.RemoveAll(x => x.id == emp.id); // remove the ones that already exist
                    }
                    
                }
                

            }
            selectEmployees_clb.Items.Clear();
            foreach (Employee employee in toBeSelected)
            {
                selectEmployees_clb.Items.Add(employee.GetFirstAndLastName());
            }
            selectedEmployees_clb.Items.Clear();
            foreach (Employee employee1 in selectedEmployees)
            {
                selectedEmployees_clb.Items.Add(employee1.GetFirstAndLastName());
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            foreach (Employee employee in dataAccessEmployeeDashboard.GetAllUsersFromDB())
            {
                foreach (var item in selectEmployees_clb.SelectedItems)
                {
                    if (item.ToString() == employee.GetFirstAndLastName())
                    {
                        selectedEmployees.Add(employee);


                    }
                }
            }
            GenerateDaata();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            foreach (Employee employee in dataAccessEmployeeDashboard.GetAllUsersFromDB())
            {
                foreach (var item in selectedEmployees_clb.SelectedItems)
                {
                    if (item.ToString() == employee.GetFirstAndLastName())
                    {
                        selectedEmployees.RemoveAll(x => x.id == employee.id); // remove the ones that already exist
                    }
                }
            }
            GenerateDaata();
        }
    }
}
