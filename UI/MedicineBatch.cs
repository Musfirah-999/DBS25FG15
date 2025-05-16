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
    public partial class MedicineBatch: Form
    {
        private readonly medicine_batchBL bll = new medicine_batchBL();
        private int selectedBatchId = -1;
        public MedicineBatch()
        {

            InitializeComponent();
            LoadMedicineList();
            LoadGrid();
        }
        private void LoadMedicineList()
        {
            comboBox1.DataSource = bll.GetMedicineList();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "medicine_id";
        }
        private void LoadGrid()
        {
            datagrid.DataSource = bll.GetAllBatches();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Medicine_batch batch = new Medicine_batch
                {
                    MedicineId = Convert.ToInt32(comboBox1.SelectedValue),
                    BatchNumber = emailBox.Text,
                    Quantity = Convert.ToInt32(contactbox.Text),
                    ExpiryDate = dateTimePicker1.Value
                };

               

                bll.AddBatch(batch);
                MessageBox.Show("Batch Added");
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedBatchId == -1)
            {
                MessageBox.Show("Please select a batch from the table.");
                return;
            }

            try
            {
                Medicine_batch batch = new Medicine_batch
                {
                    BatchId = selectedBatchId,
                    MedicineId = Convert.ToInt32(comboBox1.SelectedValue),
                    BatchNumber = emailBox.Text,
                    Quantity = Convert.ToInt32(contactbox.Text),
                    ExpiryDate = dateTimePicker1.Value
                };

                bll.UpdateBatch(batch);
                MessageBox.Show("Batch Updated");
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedBatchId == -1)
            {
                MessageBox.Show("Please select a batch from the table.");
                return;
            }

            bll.DeleteBatch(selectedBatchId);
            MessageBox.Show("Batch Deleted");
            LoadGrid();
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagrid.Rows[e.RowIndex];
                selectedBatchId = Convert.ToInt32(row.Cells["batch_id"].Value);
                comboBox1.Text = row.Cells["medicine_name"].Value.ToString();
                emailBox.Text = row.Cells["batch_no"].Value.ToString();
                contactbox.Text = row.Cells["quantity"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["expiry_date"].Value);
            }
        }

        private void logoutpictureBox_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminhomeUI a = new AdminhomeUI();
            this.Close();
            a.ShowDialog();
        }
    }
}
