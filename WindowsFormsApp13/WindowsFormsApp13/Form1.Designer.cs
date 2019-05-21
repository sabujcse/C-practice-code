namespace WindowsFormsApp13
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.RegtextBox = new System.Windows.Forms.TextBox();
            this.SpeedtextBox = new System.Windows.Forms.TextBox();
            this.MaxtextBox = new System.Windows.Forms.TextBox();
            this.MintextBox = new System.Windows.Forms.TextBox();
            this.Createbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Showbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.averagetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RegNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MaxSpeed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MinSpeed";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(147, 66);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(100, 20);
            this.NametextBox.TabIndex = 5;
            // 
            // RegtextBox
            // 
            this.RegtextBox.Location = new System.Drawing.Point(147, 119);
            this.RegtextBox.Name = "RegtextBox";
            this.RegtextBox.Size = new System.Drawing.Size(100, 20);
            this.RegtextBox.TabIndex = 6;
            // 
            // SpeedtextBox
            // 
            this.SpeedtextBox.Location = new System.Drawing.Point(147, 165);
            this.SpeedtextBox.Name = "SpeedtextBox";
            this.SpeedtextBox.Size = new System.Drawing.Size(100, 20);
            this.SpeedtextBox.TabIndex = 7;
            // 
            // MaxtextBox
            // 
            this.MaxtextBox.Location = new System.Drawing.Point(147, 214);
            this.MaxtextBox.Name = "MaxtextBox";
            this.MaxtextBox.Size = new System.Drawing.Size(100, 20);
            this.MaxtextBox.TabIndex = 8;
            // 
            // MintextBox
            // 
            this.MintextBox.Location = new System.Drawing.Point(147, 272);
            this.MintextBox.Name = "MintextBox";
            this.MintextBox.Size = new System.Drawing.Size(100, 20);
            this.MintextBox.TabIndex = 9;
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(292, 117);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(75, 23);
            this.Createbutton.TabIndex = 10;
            this.Createbutton.Text = "Create";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(319, 167);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 11;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(319, 275);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(75, 23);
            this.Showbutton.TabIndex = 12;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "AverageSpeed";
            // 
            // averagetextBox
            // 
            this.averagetextBox.Location = new System.Drawing.Point(147, 318);
            this.averagetextBox.Name = "averagetextBox";
            this.averagetextBox.Size = new System.Drawing.Size(100, 20);
            this.averagetextBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(272, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "km/h";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.averagetextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.MintextBox);
            this.Controls.Add(this.MaxtextBox);
            this.Controls.Add(this.SpeedtextBox);
            this.Controls.Add(this.RegtextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox RegtextBox;
        private System.Windows.Forms.TextBox SpeedtextBox;
        private System.Windows.Forms.TextBox MaxtextBox;
        private System.Windows.Forms.TextBox MintextBox;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Showbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox averagetextBox;
        private System.Windows.Forms.Label label7;
    }
}

