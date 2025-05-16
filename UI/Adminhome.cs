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
    public partial class AdminhomeUI: Form
    {
        public AdminhomeUI()
        {
            InitializeComponent();
        }

        private void MedicineMenu_Click(object sender, EventArgs e)
        {
            MedicineMenu medicine = new MedicineMenu();
            medicine.Show();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerMenu customer = new CustomerMenu();
            customer.Show();
        }

        private void Supplier_Click(object sender, EventArgs e)
        {
            SupplierUI supplier = new SupplierUI();
            supplier.Show();
            this.Hide();
        }

        private void CustomerBill_Click(object sender, EventArgs e)
        {
            CustomerBillUI customer = new CustomerBillUI();
            customer.Show();
            this.Hide();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            InventoryLog inventory = new InventoryLog();
            inventory.Show();
            this.Hide();
        }

        private void PurchaseOrder_Click(object sender, EventArgs e)
        {
          orderUI orderUI = new orderUI();
            this.Hide();
            orderUI.Show();
        }

        private void stock_Click(object sender, EventArgs e)
        {
            StockMenu stock = new StockMenu();
            stock.Show();
            
        }



        private void AdminhomeUI_Load(object sender, EventArgs e)
        {

        }

        private void Report_Click(object sender, EventArgs e)
        {

          Report r = new Report();
            this.Hide();
            r.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
