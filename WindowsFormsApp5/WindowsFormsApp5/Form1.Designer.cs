namespace WindowsFormsApp5
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
            this.label1 = new System.Windows.Forms.Label();
            this.salaryTextbox = new System.Windows.Forms.TextBox();
            this.rentTextbox = new System.Windows.Forms.TextBox();
            this.medicalTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculatetotalsalarybutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tatalsalaryTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic salary";
            // 
            // salaryTextbox
            // 
            this.salaryTextbox.Location = new System.Drawing.Point(212, 46);
            this.salaryTextbox.Name = "salaryTextbox";
            this.salaryTextbox.Size = new System.Drawing.Size(145, 20);
            this.salaryTextbox.TabIndex = 0;
            // 
            // rentTextbox
            // 
            this.rentTextbox.Location = new System.Drawing.Point(212, 82);
            this.rentTextbox.Name = "rentTextbox";
            this.rentTextbox.Size = new System.Drawing.Size(145, 20);
            this.rentTextbox.TabIndex = 1;
            // 
            // medicalTextbox
            // 
            this.medicalTextbox.Location = new System.Drawing.Point(212, 124);
            this.medicalTextbox.Name = "medicalTextbox";
            this.medicalTextbox.Size = new System.Drawing.Size(145, 20);
            this.medicalTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "House Rent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medical Alownece";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% of Basic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "% of Basic";
            // 
            // calculatetotalsalarybutton
            // 
            this.calculatetotalsalarybutton.Location = new System.Drawing.Point(231, 164);
            this.calculatetotalsalarybutton.Name = "calculatetotalsalarybutton";
            this.calculatetotalsalarybutton.Size = new System.Drawing.Size(126, 23);
            this.calculatetotalsalarybutton.TabIndex = 3;
            this.calculatetotalsalarybutton.Text = "Calculate Total salary";
            this.calculatetotalsalarybutton.UseVisualStyleBackColor = true;
            this.calculatetotalsalarybutton.Click += new System.EventHandler(this.calculatetotalsalarybutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Salary";
            // 
            // tatalsalaryTextbox
            // 
            this.tatalsalaryTextbox.Location = new System.Drawing.Point(212, 205);
            this.tatalsalaryTextbox.Name = "tatalsalaryTextbox";
            this.tatalsalaryTextbox.Size = new System.Drawing.Size(145, 20);
            this.tatalsalaryTextbox.TabIndex = 4;
            this.tatalsalaryTextbox.TextChanged += new System.EventHandler(this.tatalsalaryTextbox_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.calculatetotalsalarybutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(520, 341);
            this.Controls.Add(this.tatalsalaryTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.calculatetotalsalarybutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.medicalTextbox);
            this.Controls.Add(this.rentTextbox);
            this.Controls.Add(this.salaryTextbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salaryTextbox;
        private System.Windows.Forms.TextBox rentTextbox;
        private System.Windows.Forms.TextBox medicalTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculatetotalsalarybutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tatalsalaryTextbox;
    }
}

