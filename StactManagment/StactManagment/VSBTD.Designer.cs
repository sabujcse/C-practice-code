namespace StactManagment
{
    partial class VSBTD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Searchbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Date";
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromdateTimePicker.Location = new System.Drawing.Point(135, 39);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FromdateTimePicker.TabIndex = 2;
            // 
            // TodateTimePicker
            // 
            this.TodateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.TodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TodateTimePicker.Location = new System.Drawing.Point(135, 103);
            this.TodateTimePicker.Name = "TodateTimePicker";
            this.TodateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.TodateTimePicker.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(35, 185);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(300, 151);
            this.dataGridView.TabIndex = 4;
            // 
            // Searchbutton
            // 
            this.Searchbutton.Location = new System.Drawing.Point(260, 144);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(75, 23);
            this.Searchbutton.TabIndex = 5;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // VSBTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 368);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.TodateTimePicker);
            this.Controls.Add(this.FromdateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VSBTD";
            this.Text = "VSBTD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.DateTimePicker TodateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Searchbutton;
    }
}