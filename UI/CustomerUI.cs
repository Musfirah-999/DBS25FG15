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

namespace DB_finalproject.UI
{
    public partial class CustomerUI: Form
    {
        CustomerBL bl = new CustomerBL();

        public CustomerUI()
        {
            InitializeComponent();
            LoadFromDatabase();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                bl.AddToList(Namebox.Text, emailBox.Text, address.Text, contactbox.Text, passbox.Text);
                bl.SaveAll();
                LoadFromDatabase();
                MessageBox.Show("Customer added.");
                Namebox.Clear();
                emailBox.Clear();
                address.Clear();
                contactbox.Clear();
                passbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to update.");
                return;
            }

            int id = Convert.ToInt32(datagrid.CurrentRow.Cells["customer_id"].Value);
            try
            {
                bl.Update(id, Namebox.Text, emailBox.Text, address.Text, contactbox.Text, passbox.Text);
                LoadFromDatabase();
                MessageBox.Show("Updated.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            int id = Convert.ToInt32(datagrid.CurrentRow.Cells["customer_id"].Value);
            bl.Delete(id);
            LoadFromDatabase();
            MessageBox.Show("Deleted.");
        }
        private void LoadFromDatabase()
        {
            DataTable dt = bl.LoadFromDB();
            datagrid.DataSource = dt;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
