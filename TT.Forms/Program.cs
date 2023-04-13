using TrentsTroublemakersWF.Forms;
using TT.Data;
using TT.Data.Entities;
using TT.Forms.Forms;

namespace TT.Forms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            DataAccess.Init(Properties.Settings.Default.TrentsTroublemakersConnectionString);
            //Application.Run(new AddAppointmentForm());
            //Application.Run(new AddEmployeeForm());
            //Application.Run(new AddIndividualCustomerForm());
            //Application.Run(new AddPetForm());
            //Application.Run(new AdminControlsForm());
            //Application.Run(new CustomerProfileForm());
            //Application.Run(new EmployeeProfileForm());
            //Application.Run(new LoginForm());
            //Application.Run(new MainMenuForm());
            //Application.Run(new PetProfileForm());
            //Application.Run(new SearchCustomerForm());
            //Application.Run(new SearchPetForm());
            //Application.Run(new ViewAddressesFrom());



            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Employee employee = loginForm.Employee;
                Application.Run(new MainMenuForm(employee));
            }
            else
            {
                Application.Exit();
            }


        }
    }
}