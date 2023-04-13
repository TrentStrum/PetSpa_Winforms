using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrentsTroublemakersWF.Forms;
using TT.Data.Entities;

namespace TT.Forms.Forms
{
    public partial class MainMenuForm : Form
    {
        public Employee Employee { get; set; }
        public MainMenuForm(Employee employee)
        {
            Employee = employee;
            InitializeComponent();
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            //DashboardForm dashboardForm = new DashboardForm();
            //dashboardForm.MdiParent = this;
            //dashboardForm.Show();
        }
        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.MdiParent = this;
            addEmployeeForm.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.MdiParent = this;
            dashboardForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCustomerForm searchEmployeeForm = new SearchCustomerForm();
            searchEmployeeForm.MdiParent = this;
            searchEmployeeForm.Show();
        }
        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIndividualCustomerForm addIndividualCustomerForm = new AddIndividualCustomerForm();
            addIndividualCustomerForm.MdiParent = this;
            addIndividualCustomerForm.Show();
        }

        private void businessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBusinessCustomerForm addBusinessCustomerForm = new AddBusinessCustomerForm();
            addBusinessCustomerForm.MdiParent = this;
            addBusinessCustomerForm.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Employee.Role == 1)
            {
                AdminControlsForm adminControlsForm = new AdminControlsForm();
                adminControlsForm.MdiParent = this;
                adminControlsForm.Show();
            }
            else
            {
                MessageBox.Show("You NOT are Admin");
            }
        }

        private void personalInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeProfileForm employeeProfileForm = new EmployeeProfileForm(Employee.ID);
            employeeProfileForm.MdiParent = this;
            employeeProfileForm.Show();
        }

        private void searchPetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPetForm searchPetForm = new SearchPetForm();
            searchPetForm.MdiParent = this;
            searchPetForm.Show();
        }
    }
}
