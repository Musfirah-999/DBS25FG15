using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_finalproject.UI
{
    public partial class CustomerMenu: Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerUI customer = new CustomerUI();
            customer.Show();
            this.Hide();
        }

        private void Prescription_Click(object sender, EventArgs e)
        {
            PrescriptionUI prescription = new PrescriptionUI();
            prescription.Show();
            this.Hide();
        }

        private void PrescriptionDetails_Click(object sender, EventArgs e)
        {
            PrescriptionDetails prescription = new PrescriptionDetails();
            prescription.Show();
            this.Hide();
        }
    }
}
