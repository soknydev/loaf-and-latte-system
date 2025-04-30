using loaf_and_latte_system.Factories.LoafAndLatteSystem.Factories;
using LoafAndLatteSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loaf_and_latte_system.UI
{
    public partial class LoginForm : Form
    {
        private readonly LoginService _loginService;

        public LoginForm()
        {
            InitializeComponent();
            _loginService = new LoginService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            User user = _loginService.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Role}: {user.Username}");
                Hide();

                if (user.Role == "Admin")
                {
                    //new AdminDashboardForm(user).Show(); // You create this form
                    MessageBox.Show("Admin Dashboard is not implemented yet.");
                }
                else if (user.Role == "Staff")
                {
                    //new StaffDashboardForm(user).Show(); // You create this form
                    MessageBox.Show("Staff Dashboard is not implemented yet.");
                }
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
        }
    }
}
