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
    public partial class orderUI : Form
    {
        public orderUI()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            POUI pOUI = new POUI();
            this.Hide();
            pOUI.Show(this);
        }

        private void MedicineBatch_Click(object sender, EventArgs e)
        {
            PODetailsUI pODetailsUI = new PODetailsUI();    
            this.Hide();
            pODetailsUI.Show(this);
        }

        private void Medicine_Click(object sender, EventArgs e)
        {

        }
    }
}
