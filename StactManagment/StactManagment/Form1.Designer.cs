﻿namespace StactManagment
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompanycomboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategorycomboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchbutton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search And View";
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Location = new System.Drawing.Point(159, 119);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(51, 13);
            this.Company.TabIndex = 1;
            this.Company.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // CompanycomboBox
            // 
            this.CompanycomboBox.DataSource = this.companyBindingSource;
            this.CompanycomboBox.DisplayMember = "Name";
            this.CompanycomboBox.FormattingEnabled = true;
            this.CompanycomboBox.Location = new System.Drawing.Point(271, 110);
            this.CompanycomboBox.Name = "CompanycomboBox";
            this.CompanycomboBox.Size = new System.Drawing.Size(121, 21);
            this.CompanycomboBox.TabIndex = 3;
            this.CompanycomboBox.ValueMember = "ID";
            this.CompanycomboBox.SelectedIndexChanged += new System.EventHandler(this.CompanycomboBox_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(StactManagment.Models.Company);
            // 
            // CategorycomboBox
            // 
            this.CategorycomboBox.DataSource = this.categoryBindingSource;
            this.CategorycomboBox.DisplayMember = "Name";
            this.CategorycomboBox.FormattingEnabled = true;
            this.CategorycomboBox.Location = new System.Drawing.Point(271, 162);
            this.CategorycomboBox.Name = "CategorycomboBox";
            this.CategorycomboBox.Size = new System.Drawing.Size(121, 21);
            this.CategorycomboBox.TabIndex = 4;
            this.CategorycomboBox.ValueMember = "ID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(StactManagment.Models.Category);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(316, 216);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 5;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 245);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(520, 193);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.CategorycomboBox);
            this.Controls.Add(this.CompanycomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Company);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Company;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CompanycomboBox;
        private System.Windows.Forms.ComboBox CategorycomboBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
    }
}

