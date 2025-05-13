namespace DB_finalproject.UI
{
    partial class MedicineMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MedicineBatch = new System.Windows.Forms.Label();
            this.Medicine = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 92);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Medicine, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MedicineBatch, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 89);
            this.tableLayoutPanel1.TabIndex = 0;
         
            // 
            // MedicineBatch
            // 
            this.MedicineBatch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MedicineBatch.AutoSize = true;
            this.MedicineBatch.BackColor = System.Drawing.Color.Green;
            this.MedicineBatch.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineBatch.ForeColor = System.Drawing.Color.White;
            this.MedicineBatch.Location = new System.Drawing.Point(50, 52);
            this.MedicineBatch.Name = "MedicineBatch";
            this.MedicineBatch.Size = new System.Drawing.Size(181, 28);
            this.MedicineBatch.TabIndex = 1;
            this.MedicineBatch.Text = "Medicine Batch";
            this.MedicineBatch.Click += new System.EventHandler(this.MedicineBatch_Click);
            // 
            // Medicine
            // 
            this.Medicine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Medicine.AutoSize = true;
            this.Medicine.BackColor = System.Drawing.Color.Green;
            this.Medicine.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicine.ForeColor = System.Drawing.Color.White;
            this.Medicine.Location = new System.Drawing.Point(84, 8);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(113, 28);
            this.Medicine.TabIndex = 0;
            this.Medicine.Text = "Medicine";
            this.Medicine.Click += new System.EventHandler(this.Medicine_Click);
            // 
            // MedicineMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 89);
            this.Controls.Add(this.panel1);
            this.Name = "MedicineMenu";
            this.Text = "MedicineMenu";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Medicine;
        private System.Windows.Forms.Label MedicineBatch;
    }
}