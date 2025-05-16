using DB_finalproject.BL;
using DB_finalproject.DL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DB_finalproject.UI
{
    public partial class StockRequestUI: Form
    {
        public StockRequestUI()
        {
            InitializeComponent();
           
        }
 
     
            private void StockRequestUI_Load(object sender, EventArgs e)
            {
                LoadSuppliers();
                dataview();
                LoadStockRequests();
            }
        public void dataview()
        {
            DataTable dataTable = new DataTable();
            string query1 = $"Select * from stock_request";
            dataTable = DatabaseHelper.Instance.GetDataTable(query1);
            datagrid.DataSource = dataTable;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.Refresh();
        }
        private void LoadSuppliers()
            {
                string query = "SELECT supplier_id, name FROM suppliers";
                var dt = DB_finalproject.DL.DatabaseHelper.Instance.GetDataTable(query);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "supplier_id";
            }

            private void LoadStockRequests()
            {
            StBL bl = new StBL();
            datagrid.DataSource = bl.GetRequests();
            }

        private void AddStock_Click(object sender, EventArgs e)
        {
            ST model = new ST()
            {
                PharmacistId = 1, 
                SupplierId = Convert.ToInt32(comboBox1.SelectedValue),
                RequestDate = dateTimePicker1.Value,
                Status = comboBoxStatus.SelectedItem.ToString() 
            };

            StBL bl = new StBL();
            int id = bl.AddRequest(model);
            MessageBox.Show("Stock request added. ID: " + id);
            LoadStockRequests();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count > 0)
            {
                StBL bl = new StBL();
                int requestId = Convert.ToInt32(datagrid.SelectedRows[0].Cells["request_id"].Value);
                bl.DeleteRequest(requestId);
                MessageBox.Show("Stock request deleted.");
                LoadStockRequests();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            AdminhomeUI admin = new AdminhomeUI();
            admin.Show();
            this.Close();
        }

        private void logoutpictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
  }
 