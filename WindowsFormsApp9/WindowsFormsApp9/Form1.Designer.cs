namespace WindowsFormsApp9
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
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.ContactTextbox = new System.Windows.Forms.TextBox();
            this.AddressTextbox = new System.Windows.Forms.TextBox();
            this.QuantityTextbox = new System.Windows.Forms.TextBox();
            this.OrderTextbox = new System.Windows.Forms.ComboBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OrderOrning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Order";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer Information";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(129, 69);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(176, 20);
            this.NameTextbox.TabIndex = 6;
            // 
            // ContactTextbox
            // 
            this.ContactTextbox.Location = new System.Drawing.Point(129, 108);
            this.ContactTextbox.Name = "ContactTextbox";
            this.ContactTextbox.Size = new System.Drawing.Size(176, 20);
            this.ContactTextbox.TabIndex = 7;
            // 
            // AddressTextbox
            // 
            this.AddressTextbox.Location = new System.Drawing.Point(129, 149);
            this.AddressTextbox.Name = "AddressTextbox";
            this.AddressTextbox.Size = new System.Drawing.Size(176, 20);
            this.AddressTextbox.TabIndex = 8;
            // 
            // QuantityTextbox
            // 
            this.QuantityTextbox.Location = new System.Drawing.Point(129, 238);
            this.QuantityTextbox.Name = "QuantityTextbox";
            this.QuantityTextbox.Size = new System.Drawing.Size(176, 20);
            this.QuantityTextbox.TabIndex = 10;
            // 
            // OrderTextbox
            // 
            this.OrderTextbox.FormattingEnabled = true;
            this.OrderTextbox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.OrderTextbox.Location = new System.Drawing.Point(129, 193);
            this.OrderTextbox.Name = "OrderTextbox";
            this.OrderTextbox.Size = new System.Drawing.Size(176, 21);
            this.OrderTextbox.TabIndex = 11;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(510, 22);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(261, 376);
            this.richTextBox.TabIndex = 12;
            this.richTextBox.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(99, 321);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(103, 23);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OrderOrning
            // 
            this.OrderOrning.AutoSize = true;
            this.OrderOrning.Location = new System.Drawing.Point(343, 200);
            this.OrderOrning.Name = "OrderOrning";
            this.OrderOrning.Size = new System.Drawing.Size(0, 13);
            this.OrderOrning.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OrderOrning);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.OrderTextbox);
            this.Controls.Add(this.QuantityTextbox);
            this.Controls.Add(this.AddressTextbox);
            this.Controls.Add(this.ContactTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.TextBox ContactTextbox;
        private System.Windows.Forms.TextBox AddressTextbox;
        private System.Windows.Forms.TextBox QuantityTextbox;
        private System.Windows.Forms.ComboBox OrderTextbox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label OrderOrning;
        private System.Windows.Forms.Button button1;
    }
}

