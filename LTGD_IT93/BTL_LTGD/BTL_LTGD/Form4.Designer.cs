﻿
namespace BTL_LTGD
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.benhVienDBDataSet = new BTL_LTGD.BenhVienDBDataSet();
            this.benhVienDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benhVienDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.benhVienDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhVienDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhVienDBDataSetBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // benhVienDBDataSet
            // 
            this.benhVienDBDataSet.DataSetName = "BenhVienDBDataSet";
            this.benhVienDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // benhVienDBDataSetBindingSource
            // 
            this.benhVienDBDataSetBindingSource.DataSource = this.benhVienDBDataSet;
            this.benhVienDBDataSetBindingSource.Position = 0;
            // 
            // benhVienDBDataSetBindingSource1
            // 
            this.benhVienDBDataSetBindingSource1.DataSource = this.benhVienDBDataSet;
            this.benhVienDBDataSetBindingSource1.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(24, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 247);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // btnBack1
            // 
            this.btnBack1.AutoSize = true;
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack1.Location = new System.Drawing.Point(317, 340);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(136, 42);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.Text = "TRỞ LẠI";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.benhVienDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhVienDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benhVienDBDataSetBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource benhVienDBDataSetBindingSource1;
        private BenhVienDBDataSet benhVienDBDataSet;
        private System.Windows.Forms.BindingSource benhVienDBDataSetBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack1;
    }
}