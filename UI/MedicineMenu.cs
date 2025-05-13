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
    public partial class MedicineMenu: Form
    {
        public MedicineMenu()
        {
            InitializeComponent();
        }

        private void Medicine_Click(object sender, EventArgs e)
        {
            MedicineUI medicine = new MedicineUI();
            medicine.Show();
            this.Close();
        }
        private void MedicineBatch_Click(object sender, EventArgs e)
        {
            MedicineBatch medicineBatch = new MedicineBatch();
            medicineBatch.Show();
            this.Close();
        }
    }
}
