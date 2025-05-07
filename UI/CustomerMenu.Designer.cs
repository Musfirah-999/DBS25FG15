namespace DB_finalproject.UI
{
    partial class CustomerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PrescriptionDetails = new System.Windows.Forms.Label();
            this.Prescription = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PrescriptionDetails, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Prescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Customer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // PrescriptionDetails
            // 
            this.PrescriptionDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrescriptionDetails.AutoSize = true;
            this.PrescriptionDetails.BackColor = System.Drawing.Color.Green;
            this.PrescriptionDetails.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionDetails.ForeColor = System.Drawing.Color.White;
            this.PrescriptionDetails.Location = new System.Drawing.Point(44, 110);
            this.PrescriptionDetails.Name = "PrescriptionDetails";
            this.PrescriptionDetails.Size = new System.Drawing.Size(231, 28);
            this.PrescriptionDetails.TabIndex = 2;
            this.PrescriptionDetails.Text = "Prescription details";
            this.PrescriptionDetails.Click += new System.EventHandler(this.PrescriptionDetails_Click);
            // 
            // Prescription
            // 
            this.Prescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Prescription.AutoSize = true;
            this.Prescription.BackColor = System.Drawing.Color.Green;
            this.Prescription.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prescription.ForeColor = System.Drawing.Color.White;
            this.Prescription.Location = new System.Drawing.Point(28, 59);
            this.Prescription.Name = "Prescription";
            this.Prescription.Size = new System.Drawing.Size(263, 28);
            this.Prescription.TabIndex = 1;
            this.Prescription.Text = "Customer Prescription";
            this.Prescription.Click += new System.EventHandler(this.Prescription_Click);
            // 
            // Customer
            // 
            this.Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Customer.AutoSize = true;
            this.Customer.BackColor = System.Drawing.Color.Green;
            this.Customer.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.ForeColor = System.Drawing.Color.White;
            this.Customer.Location = new System.Drawing.Point(100, 10);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(119, 28);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Customer";
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 155);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Prescription;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.Label PrescriptionDetails;
    }
}