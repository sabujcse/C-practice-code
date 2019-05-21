namespace Helloworld
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
            this.showButton = new System.Windows.Forms.Button();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.Label();
            this.SecondNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(330, 131);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(120, 29);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Location = new System.Drawing.Point(207, 46);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(194, 20);
            this.FirstnameTextBox.TabIndex = 0;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.AutoSize = true;
            this.FirstNameBox.Location = new System.Drawing.Point(116, 53);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(85, 13);
            this.FirstNameBox.TabIndex = 2;
            this.FirstNameBox.Text = "Enter First Name";
            this.FirstNameBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // SecondNameTextbox
            // 
            this.SecondNameTextbox.Location = new System.Drawing.Point(207, 92);
            this.SecondNameTextbox.Name = "SecondNameTextbox";
            this.SecondNameTextbox.Size = new System.Drawing.Size(194, 20);
            this.SecondNameTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Second Name";
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.Location = new System.Drawing.Point(207, 185);
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(194, 20);
            this.FullNameTextbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your Full  Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 266);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.SecondNameTextbox);
            this.Controls.Add(this.FullNameTextbox);
            this.Controls.Add(this.FirstnameTextBox);
            this.Controls.Add(this.showButton);
            this.Name = "Form1";
            this.Text = "Show hello world";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox FirstnameTextBox;
        private System.Windows.Forms.Label FirstNameBox;
        private System.Windows.Forms.TextBox SecondNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameTextbox;
        private System.Windows.Forms.Label label3;
    }
}

