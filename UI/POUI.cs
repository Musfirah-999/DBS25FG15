using DB_finalproject.BL;
using DB_finalproject.Models;
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
    public partial class POUI : Form
    {
        private POBL bll = new POBL();
        public POUI()
        {
            InitializeComponent();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var po = new PO
                {
                    SupplierId = Convert.ToInt32(comboBoxSupplier.SelectedValue),
                    RequestId = Convert.ToInt32(comboBoxRequest.SelectedValue),
                    DateIssued = dateTimePickerIssued.Value.Date
                };

                if (bll.AddOrder(po))
                {
                    MessageBox.Show("Purchase Order added successfully!");
                    LoadOrders();
                }
                else
                {
                    MessageBox.Show("Failed to add Purchase Order.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void POUI_Load(object sender, EventArgs e)
        {

            comboBoxSupplier.DataSource = bll.GetSuppliers();
            comboBoxSupplier.DisplayMember = "name";
            comboBoxSupplier.ValueMember = "supplier_id";

            comboBoxRequest.DataSource = bll.GetRequests();
            comboBoxRequest.DisplayMember = "request_id";
            comboBoxRequest.ValueMember = "request_id";

            LoadOrders();
            dateTimePickerIssued.Value = DateTime.Now;

        }
        private void LoadOrders()
        {
            dataGridViewOrders.DataSource = bll.GetOrders();
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to delete.");
                return;
            }

            int orderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["order_id"].Value);

            if (bll.DeleteOrder(orderId))
            {
                MessageBox.Show("Order deleted successfully!");
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Failed to delete order.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminhomeUI adminhomeUI = new AdminhomeUI();
            this.Hide();
            adminhomeUI.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
