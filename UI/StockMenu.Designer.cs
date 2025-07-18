﻿namespace DB_finalproject.UI
{
    partial class StockMenu
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
            this.StockRequestDetails = new System.Windows.Forms.Label();
            this.StockRequest = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.StockRequestDetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StockRequest, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(277, 115);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // StockRequestDetails
            // 
            this.StockRequestDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StockRequestDetails.AutoSize = true;
            this.StockRequestDetails.BackColor = System.Drawing.Color.Green;
            this.StockRequestDetails.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockRequestDetails.ForeColor = System.Drawing.Color.White;
            this.StockRequestDetails.Location = new System.Drawing.Point(13, 72);
            this.StockRequestDetails.Name = "StockRequestDetails";
            this.StockRequestDetails.Size = new System.Drawing.Size(250, 28);
            this.StockRequestDetails.TabIndex = 1;
            this.StockRequestDetails.Text = "Stock Request Details";
            this.StockRequestDetails.Click += new System.EventHandler(this.StockRequestDetails_Click);
            // 
            // StockRequest
            // 
            this.StockRequest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StockRequest.AutoSize = true;
            this.StockRequest.BackColor = System.Drawing.Color.Green;
            this.StockRequest.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockRequest.ForeColor = System.Drawing.Color.White;
            this.StockRequest.Location = new System.Drawing.Point(55, 14);
            this.StockRequest.Name = "StockRequest";
            this.StockRequest.Size = new System.Drawing.Size(167, 28);
            this.StockRequest.TabIndex = 0;
            this.StockRequest.Text = "Stock Request";
            this.StockRequest.Click += new System.EventHandler(this.StockRequest_Click);
            // 
            // StockMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 116);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockMenu";
            this.Text = "StockMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label StockRequestDetails;
        private System.Windows.Forms.Label StockRequest;
    }
}