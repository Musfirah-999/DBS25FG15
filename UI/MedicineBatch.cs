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

namespace DB_finalproject.UI
{
    public partial class MedicineBatch: Form
    {
        medicine_batchBL bl = new medicine_batchBL();
        private int selectedBatchId = -1;
        private Dictionary<string, int> medicineMap;


        public MedicineBatch()
        {
            InitializeComponent();
            LoadMedicineDropdown();
            LoadGrid();
        }
        private void LoadMedicineDropdown()
        {
            medicineMap = bl.GetMedicineMap();
            namecomboBox.DataSource = new BindingSource(medicineMap, null);
            namecomboBox.DisplayMember = "Key";
            namecomboBox.ValueMember = "Value";
        }
        private void LoadGrid()
        {
            mbdataViewGrid.DataSource = bl.GetAllBatchesTable();
        }
        private void ClearFields()
        {

            batchnotxtbox.Clear();
            quantitytxtbox.Clear();
            namecomboBox.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Today;
            selectedBatchId = -1;
        }

        private void MedicineBatch_Load(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string batchNumber = batchnotxtbox.Text;
                int quantity = int.Parse(quantitytxtbox.Text);
                int medicineId = (int)namecomboBox.SelectedValue;
                DateTime expiry = dateTimePicker.Value;

                bl.AddToDB(batchNumber, expiry, medicineId, quantity);
                MessageBox.Show("Batch added successfully!");
                LoadGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


      
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (selectedBatchId == -1)
            {
                MessageBox.Show("Please select a batch first!");
                return;
            }

            try
            {
                string batchNumber = batchnotxtbox.Text;
                int quantity = int.Parse(quantitytxtbox.Text);
                int medicineId = (int)namecomboBox.SelectedValue;
                DateTime expiry = dateTimePicker.Value;

                bl.UpdateBatch(selectedBatchId, batchNumber, expiry, medicineId, quantity);
                MessageBox.Show("Batch updated successfully!");
                LoadGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            if (selectedBatchId == -1)
            {
                MessageBox.Show("Please select a batch to delete.");
                return;
            }

            bl.DeleteBatch(selectedBatchId);
            MessageBox.Show("Batch deleted.");
            LoadGrid();
            ClearFields();
        }

        private void mbdataViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = mbdataViewGrid.Rows[e.RowIndex];
                selectedBatchId = Convert.ToInt32(row.Cells["batch_id"].Value);
                batchnotxtbox.Text = row.Cells["batch_number"].Value.ToString();
                quantitytxtbox.Text = row.Cells["quantity"].Value.ToString();
                dateTimePicker.Value = Convert.ToDateTime(row.Cells["expiry_date"].Value);
                namecomboBox.SelectedIndex = namecomboBox.FindStringExact(row.Cells["name"].Value.ToString());
            }

        }
  
    }
    }
    

