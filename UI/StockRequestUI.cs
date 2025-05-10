using DB_finalproject.BL;
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
using DB_finalproject.DL;
using DB_finalproject.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_finalproject.UI
{
    public partial class StockRequestUI : Form
    {
       
        public StockRequestUI()
        {
            InitializeComponent();
        }

        private void StockRequestUI_Load(object sender, EventArgs e)
        {

            LoadSuppliers();
            LoadStockRequests();
       
      
        }
        private void LoadSuppliers()
        {
            string query = "SELECT supplier_id, name FROM suppliers";
            var dt = DatabaseHelper.Instance.GetDataTable(query);
            suppcombobox.DataSource = dt;
            suppcombobox.DisplayMember = "name";
            suppcombobox.ValueMember = "supplier_id";
        }

        private void LoadStockRequests()
        {
            StBL bl = new StBL();
            datagrid.DataSource = bl.GetRequests();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            ST model = new ST()
            {
              
                SupplierId = Convert.ToInt32(suppcombobox.SelectedValue),
                RequestDate = dateTimePicker1.Value,
                Status = "Pending"
            };

            StBL bl = new StBL();
            int id = bl.AddRequest(model);
            MessageBox.Show("Stock request added. ID: " + id);
            LoadStockRequests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                int requestId = Convert.ToInt32(datagrid.SelectedRows[0].Cells["request_id"].Value);
                StBL bl = new StBL();
                bl.DeleteRequest(requestId);
                MessageBox.Show("Stock request deleted.");
                LoadStockRequests();
            }
        }
    }
}
