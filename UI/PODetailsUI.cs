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
    public partial class PODetailsUI : Form
    {
        private PODetailBL bll = new PODetailBL();

        public PODetailsUI()
        {
            InitializeComponent();
        }

        private void PODetailsUI_Load(object sender, EventArgs e)
        {
            // Load order IDs to ComboBox
            POBL poBL = new POBL();
            comboBoxOrder.DataSource = poBL.GetOrders();
            comboBoxOrder.DisplayMember = "order_id";
            comboBoxOrder.ValueMember = "order_id";

            LoadDetailsGrid();
        }
        private void LoadDetailsGrid()
        {
            if (comboBoxOrder.SelectedValue != null)
            {
                int orderId = Convert.ToInt32(comboBoxOrder.SelectedValue);
                dataGridViewDetails.DataSource = bll.GetDetailsByOrderId(orderId);
            }
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            if (comboBoxOrder.SelectedValue == null)
            {
                MessageBox.Show("Select an order first.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Enter valid quantity.");
                return;
            }

            if (!decimal.TryParse(txtTotalAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Enter valid total amount.");
                return;
            }

            var detail = new PODetails
            {
                OrderId = Convert.ToInt32(comboBoxOrder.SelectedValue),
                Quantity = qty,
                TotalAmount = amount
            };

            if (bll.AddDetail(detail))
            {
                MessageBox.Show("Detail added successfully!");
                LoadDetailsGrid();
                txtQuantity.Clear();
                txtTotalAmount.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add detail.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select detail to delete.");
                return;
            }

            int detailId = Convert.ToInt32(dataGridViewDetails.SelectedRows[0].Cells["detail_id"].Value);

            if (bll.DeleteDetail(detailId))
            {
                MessageBox.Show("Detail deleted.");
                LoadDetailsGrid();
            }
            else
            {
                MessageBox.Show("Failed to delete detail.");
            }
        }
 

        private void comboBoxOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadDetailsGrid();
        }
    }
}
