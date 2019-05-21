namespace WindowsFormsApp12
{
    partial class DepartmentsUi
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
            this.findbutton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.savebutton = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.codetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.couresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depcourseDataSet = new WindowsFormsApp12.DepcourseDataSet();
            this.couresTableAdapter = new WindowsFormsApp12.DepcourseDataSetTableAdapters.CouresTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depcourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(455, 80);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(75, 23);
            this.findbutton.TabIndex = 28;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(371, 80);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(290, 80);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 26;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(346, 45);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(112, 20);
            this.searchtextBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Inser Id";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(290, 252);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 23;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(26, 294);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(689, 164);
            this.dataGridView.TabIndex = 22;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(185, 252);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 21;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(145, 139);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(139, 20);
            this.nametextBox.TabIndex = 19;
            // 
            // codetextBox
            // 
            this.codetextBox.Location = new System.Drawing.Point(145, 97);
            this.codetextBox.Name = "codetextBox";
            this.codetextBox.Size = new System.Drawing.Size(139, 20);
            this.codetextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "CouresId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Code";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.courseBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(WindowsFormsApp12.Models.Course);
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataSource = typeof(WindowsFormsApp12.Models.Departments);
            // 
            // couresBindingSource
            // 
            this.couresBindingSource.DataMember = "Coures";
            this.couresBindingSource.DataSource = this.depcourseDataSet;
            // 
            // depcourseDataSet
            // 
            this.depcourseDataSet.DataSetName = "DepcourseDataSet";
            this.depcourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // couresTableAdapter
            // 
            this.couresTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Course";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.departmentsBindingSource1;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(145, 216);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(139, 21);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.ValueMember = "Id";
            // 
            // departmentsBindingSource1
            // 
            this.departmentsBindingSource1.DataSource = typeof(WindowsFormsApp12.Models.Departments);
            // 
            // DepartmentsUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 486);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.codetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DepartmentsUi";
            this.Text = "DepartmentsUi";
            this.Load += new System.EventHandler(this.DepartmentsUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depcourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox codetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DepcourseDataSet depcourseDataSet;
        private System.Windows.Forms.BindingSource couresBindingSource;
        private DepcourseDataSetTableAdapters.CouresTableAdapter couresTableAdapter;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource departmentsBindingSource1;
    }
}