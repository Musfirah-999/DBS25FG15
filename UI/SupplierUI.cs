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
    public partial class SupplierUI: Form
    {
        SupplierBL bl = new SupplierBL();
        public SupplierUI()
        {
            InitializeComponent();
            LoadFromDatabase();
            dataview();
        }

        private void SupplierUI_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (supplierdataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }
            if (supplierdataGridView.CurrentRow != null)
            {
                int id = Convert.ToInt32(supplierdataGridView.CurrentRow.Cells["medicine_id"].Value);
                bl.delete(id);
                LoadFromDatabase();
                MessageBox.Show("Deleted successfully.");
            }
        }
        public void dataview()
        {
            DataTable dataTable = new DataTable();
            string query1 = $"Select * from suppliers";
            dataTable = DatabaseHelper.Instance.GetDataTable(query1);
            supplierdataGridView.DataSource = dataTable;
            supplierdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            supplierdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            supplierdataGridView.Refresh();
        }
        private void LoadFromDatabase()
        {
            supplierdataGridView.DataSource = bl.LoadFromDB();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            try
            {
                bl.AddToList(nametextBox.Text, emailtextBox.Text, contacttextBox.Text, passtextBox.Text);
                bl.SaveAll();
                LoadFromDatabase();
                MessageBox.Show("All data saved to database.");
                nametextBox.Clear();
                emailtextBox.Clear();
                contacttextBox.Clear();
                passtextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if(supplierdataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }
            if(supplierdataGridView.CurrentRow != null)
            {
                int id = Convert.ToInt32(supplierdataGridView.CurrentRow.Cells["supplier_id"].Value);
                try
                {
                    bl.Update(id, nametextBox.Text, emailtextBox.Text, contacttextBox.Text, passtextBox.Text);
                    LoadFromDatabase();
                    MessageBox.Show("Updated succesfully.");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminhomeUI adminhomeUI = new AdminhomeUI();
            this.Close();
            adminhomeUI.Show();
        }

        private void logoutpictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
