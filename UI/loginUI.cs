using DB_finalproject.BL;
using DB_finalproject.Models;
using DB_finalproject.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_finalproject
{
    public partial class loginUI: Form
    {
        public loginUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        { 
            var user = new UserModel
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };
            UserBL userBL = new UserBL();
            bool ok = userBL.Login(user);

            if (!ok)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                string role = CmbRole.SelectedItem?.ToString();
            Form dash = null;
            switch (role)
            {
                case "Pharmacist":
                    dash = new AdminhomeUI();  
                    break;
                case "Supplier":
                    dash = new supplierhomeUI();
                    break;
                case "Customer":
                    dash = new CustomerHome();
                    break;
                default:
                    MessageBox.Show("Please select a role.", "No Role", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }
            dash.Show();
            this.Close();

        }

    }
}

