namespace Stackmanagment
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompanycomboBox = new System.Windows.Forms.ComboBox();
            this.categorysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategorycomboBox = new System.Windows.Forms.ComboBox();
            this.categorysBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categorysBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.categorysBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.categorysBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.categorysBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search And View item Summery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // CompanycomboBox
            // 
            this.CompanycomboBox.FormattingEnabled = true;
            this.CompanycomboBox.Location = new System.Drawing.Point(184, 99);
            this.CompanycomboBox.Name = "CompanycomboBox";
            this.CompanycomboBox.Size = new System.Drawing.Size(141, 21);
            this.CompanycomboBox.TabIndex = 3;
            // 
            // categorysBindingSource
            // 

            // 
            // CategorycomboBox
            // 
            this.CategorycomboBox.DataSource = this.categorysBindingSource5;
            this.CategorycomboBox.FormattingEnabled = true;
            this.CategorycomboBox.Location = new System.Drawing.Point(184, 144);
            this.CategorycomboBox.Name = "CategorycomboBox";
            this.CategorycomboBox.Size = new System.Drawing.Size(141, 21);
            this.CategorycomboBox.TabIndex = 4;
            // 
            // categorysBindingSource2
            // 
            this.categorysBindingSource2.DataSource = typeof(Stackmanagment.Models.Category);
            // 
            // categorysBindingSource1
            // 
            this.categorysBindingSource1.DataSource = typeof(Stackmanagment.Models.Category);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 231);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(637, 208);
            this.dataGridView.TabIndex = 6;
            // 
            // categorysBindingSource3
            // 
            this.categorysBindingSource3.DataSource = typeof(Stackmanagment.Models.Category);
            // 
            // categorysBindingSource4
            // 
            this.categorysBindingSource4.DataSource = typeof(Stackmanagment.Models.Category);
            // 
            // categorysBindingSource5
            // 
            this.categorysBindingSource5.DataSource = typeof(Stackmanagment.Models.Category);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 451);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CategorycomboBox);
            this.Controls.Add(this.CompanycomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorysBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CompanycomboBox;
        private System.Windows.Forms.ComboBox CategorycomboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource categorysBindingSource;
        private System.Windows.Forms.BindingSource categorysBindingSource1;
        private System.Windows.Forms.BindingSource categorysBindingSource2;
        private System.Windows.Forms.BindingSource categorysBindingSource3;
        private System.Windows.Forms.BindingSource categorysBindingSource5;
        private System.Windows.Forms.BindingSource categorysBindingSource4;
    }
}

