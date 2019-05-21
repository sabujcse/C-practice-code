namespace WindowsFormsApp10
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
            this.NameText = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.Label();
            this.CityText = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(127, 72);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(35, 13);
            this.NameText.TabIndex = 0;
            this.NameText.Text = "Name";
            // 
            // AddressText
            // 
            this.AddressText.AutoSize = true;
            this.AddressText.Location = new System.Drawing.Point(127, 113);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(45, 13);
            this.AddressText.TabIndex = 1;
            this.AddressText.Text = "Address";
            // 
            // CityText
            // 
            this.CityText.AutoSize = true;
            this.CityText.Location = new System.Drawing.Point(127, 158);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(55, 13);
            this.CityText.TabIndex = 2;
            this.CityText.Text = "City Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(209, 72);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(148, 20);
            this.NameBox.TabIndex = 3;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(209, 110);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(148, 20);
            this.AddressBox.TabIndex = 4;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(209, 151);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(148, 20);
            this.CityTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Information";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(282, 211);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.CityText);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.NameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label AddressText;
        private System.Windows.Forms.Label CityText;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
    }
}

