using DB_finalproject.BL;
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
    public partial class MedicineUI : Form
    {
        MedicineBL bl = new MedicineBL();

        public MedicineUI()
        {
            InitializeComponent();
            LoadFromDatabase();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loginUI l = new loginUI();
            this.Hide();
            l.ShowDialog();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            try
            {
                bl.AddToList(nametextBox.Text, pricetextBox.Text);
                medicinedataGridView.DataSource = null;
                medicinedataGridView.DataSource = bl.GetList().Select(m => new { m.Name, m.Price }).ToList();
                nametextBox.Clear();
                pricetextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (medicinedataGridView.CurrentRow != null)
            {
                int id = Convert.ToInt32(medicinedataGridView.CurrentRow.Cells["medicine_id"].Value);
                try
                {
                    bl.Update(id, nametextBox.Text, pricetextBox.Text);
                    LoadFromDatabase();
                    MessageBox.Show("Updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (medicinedataGridView.CurrentRow != null)
            {
                int id = Convert.ToInt32(medicinedataGridView.CurrentRow.Cells["medicine_id"].Value);
                bl.Delete(id);
                LoadFromDatabase();
                MessageBox.Show("Deleted successfully.");
            }

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadFromDatabase()
        {
            medicinedataGridView.DataSource = bl.LoadFromDB();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

            bl.SaveAll();
            LoadFromDatabase();
            MessageBox.Show("All data saved to database.");
        }
    }
}
