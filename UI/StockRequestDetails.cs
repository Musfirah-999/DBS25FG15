using System;
using DB_finalproject.BL;
using DB_finalproject.Models;
using DB_finalproject.DL;
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
    public partial class StockRequestDetails: Form
    {
        public StockRequestDetails()
        {
            InitializeComponent();
        }
        private void StockRequestDetails_Load(object sender, EventArgs e)
        {
            LoadRequestIDs();
            LoadMedicines();
            LoadRequestDetailsGrid();
            dataview();
        }

        private void LoadRequestIDs()
        {
            StDetailBL bl = new StDetailBL();
            var dt = bl.GetAllRequestIDs();
            RequestComboxBox.DataSource = dt;
            RequestComboxBox.DisplayMember = "request_id";
            RequestComboxBox.ValueMember = "request_id";
        }
        public void dataview()
        {
            DataTable dataTable = new DataTable();
            string query1 = $"Select * from stock_request_details";
            dataTable = DatabaseHelper.Instance.GetDataTable(query1);
            datagrid.DataSource = dataTable;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.Refresh();
        }
        private void LoadMedicines()
        {
            StDetailBL bl = new StDetailBL();
            var dt = bl.GetAllMedicines();
            MedicineCombobox.DataSource = dt;
            MedicineCombobox.DisplayMember = "name";
            MedicineCombobox.ValueMember = "medicine_id";
        }

        private void LoadRequestDetailsGrid()
        {
            if (RequestComboxBox.SelectedValue != null)
            {
                int requestId = Convert.ToInt32(RequestComboxBox.SelectedValue);
                StDetailBL bl = new StDetailBL();
                datagrid.DataSource = bl.GetRequestDetails(requestId);
            }
        }



        private void AddMedicine_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(quantitybox.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            StDetail model = new StDetail()
            {
                RequestId = Convert.ToInt32(RequestComboxBox.SelectedValue),
                MedicineId = Convert.ToInt32(MedicineCombobox.SelectedValue),
                RequestedQuantity = qty
            };

            StDetailBL bl = new StDetailBL();
            bl.AddRequestDetail(model);
            MessageBox.Show("Medicine added to stock request.");
            LoadRequestDetailsGrid();
        }

        private void Delete_Click(object sender, EventArgs e)
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
