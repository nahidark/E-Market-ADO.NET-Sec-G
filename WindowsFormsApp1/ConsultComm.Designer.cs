﻿namespace WindowsFormsApp1
{
    partial class ConsultComm
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
            this.tbnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbville = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbcl = new System.Windows.Forms.ComboBox();
            this.dgvcomm = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvdet = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbnom
            // 
            this.tbnom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbnom.Location = new System.Drawing.Point(133, 106);
            this.tbnom.Margin = new System.Windows.Forms.Padding(4);
            this.tbnom.Name = "tbnom";
            this.tbnom.Size = new System.Drawing.Size(132, 22);
            this.tbnom.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 116;
            this.label2.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 115;
            this.label1.Text = "Code Client :";
            // 
            // tbville
            // 
            this.tbville.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbville.Location = new System.Drawing.Point(133, 147);
            this.tbville.Margin = new System.Windows.Forms.Padding(4);
            this.tbville.Name = "tbville";
            this.tbville.Size = new System.Drawing.Size(132, 22);
            this.tbville.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(32, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 119;
            this.label7.Text = "City  :";
            // 
            // cbcl
            // 
            this.cbcl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbcl.FormattingEnabled = true;
            this.cbcl.Location = new System.Drawing.Point(133, 73);
            this.cbcl.Name = "cbcl";
            this.cbcl.Size = new System.Drawing.Size(132, 24);
            this.cbcl.TabIndex = 121;
            this.cbcl.SelectedIndexChanged += new System.EventHandler(this.cbcl_SelectedIndexChanged);
            this.cbcl.TextChanged += new System.EventHandler(this.cbcl_TextChanged);
            // 
            // dgvcomm
            // 
            this.dgvcomm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvcomm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomm.Location = new System.Drawing.Point(597, 76);
            this.dgvcomm.Name = "dgvcomm";
            this.dgvcomm.RowHeadersWidth = 51;
            this.dgvcomm.RowTemplate.Height = 24;
            this.dgvcomm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcomm.Size = new System.Drawing.Size(470, 183);
            this.dgvcomm.TabIndex = 122;
            this.dgvcomm.SelectionChanged += new System.EventHandler(this.dgvcomm_SelectionChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(423, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 64);
            this.label3.TabIndex = 123;
            this.label3.Text = "Customer Orders :";
            // 
            // dgvdet
            // 
            this.dgvdet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dgvdet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdet.Location = new System.Drawing.Point(597, 356);
            this.dgvdet.Name = "dgvdet";
            this.dgvdet.RowHeadersWidth = 51;
            this.dgvdet.RowTemplate.Height = 24;
            this.dgvdet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdet.Size = new System.Drawing.Size(470, 199);
            this.dgvdet.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(417, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 76);
            this.label5.TabIndex = 127;
            this.label5.Text = "Order Details :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 51);
            this.panel1.TabIndex = 136;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(236, -5);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(612, 56);
            this.label8.TabIndex = 133;
            this.label8.Text = "VIEWING ORDERS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(67, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 59);
            this.button1.TabIndex = 137;
            this.button1.Text = "Delete Selected Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvcomm);
            this.Controls.Add(this.cbcl);
            this.Controls.Add(this.tbville);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultComm";
            this.Text = "ConsultComm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultComm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbville;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbcl;
        private System.Windows.Forms.DataGridView dgvcomm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}