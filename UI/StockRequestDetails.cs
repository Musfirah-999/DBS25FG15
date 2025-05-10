using DB_finalproject.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_finalproject.BL;
using DB_finalproject.Models;

namespace DB_finalproject.UI
{
    public partial class StockRequestDetails: Form
    {
        public StockRequestDetails()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StockRequestDetails_Load(object sender, EventArgs e)
        {
            LoadRequestIDs();
            LoadMedicines();
            LoadRequestDetailsGrid();
        }
        private void LoadRequestIDs()
        {
            StDetailBL bl = new StDetailBL();
            var dt = bl.GetAllRequestIDs();
            reqcomboBox.DataSource = dt;
            reqcomboBox.DisplayMember = "request_id";
            reqcomboBox.ValueMember = "request_id";
        }

        private void LoadMedicines()
        {
            StDetailBL bl = new StDetailBL();
            var dt = bl.GetAllMedicines();
            medcomboBox.DataSource = dt;
            medcomboBox.DisplayMember = "name";
            medcomboBox.ValueMember = "medicine_id";
        }
        private void LoadRequestDetailsGrid()
        {
            if (reqcomboBox.SelectedValue != null)
            {
                int requestId = Convert.ToInt32(reqcomboBox.SelectedValue);
                StDetailBL bl = new StDetailBL();
                datagrid.DataSource = bl.GetRequestDetails(requestId);
            }
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(quantitybox.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            StDetail model = new StDetail()
            {
                RequestId = Convert.ToInt32(reqcomboBox.SelectedValue),
                MedicineId = Convert.ToInt32(medcomboBox.SelectedValue),
                RequestedQuantity = qty
            };

            StDetailBL bl = new StDetailBL();
            bl.AddRequestDetail(model);
            MessageBox.Show("Medicine added to stock request.");
            LoadRequestDetailsGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                int detailId = Convert.ToInt32(datagrid.SelectedRows[0].Cells["detail_id"].Value);
                StDetailBL bl = new StDetailBL();
                bl.DeleteRequestDetail(detailId);
                MessageBox.Show("Request detail deleted.");
                LoadRequestDetailsGrid();
            }
        }
    }
}
