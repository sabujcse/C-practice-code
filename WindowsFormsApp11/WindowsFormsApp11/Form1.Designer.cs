namespace WindowsFormsApp11
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
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.contacttextBox = new System.Windows.Forms.TextBox();
            this.reghNotextBox = new System.Windows.Forms.TextBox();
            this.depidtextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.showbutton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.serchText = new System.Windows.Forms.TextBox();
            this.findbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "RegNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DepartmentId";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(194, 53);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(158, 20);
            this.nametextBox.TabIndex = 5;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(194, 93);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(158, 20);
            this.addresstextBox.TabIndex = 6;
            // 
            // contacttextBox
            // 
            this.contacttextBox.Location = new System.Drawing.Point(194, 139);
            this.contacttextBox.Name = "contacttextBox";
            this.contacttextBox.Size = new System.Drawing.Size(158, 20);
            this.contacttextBox.TabIndex = 7;
            // 
            // reghNotextBox
            // 
            this.reghNotextBox.Location = new System.Drawing.Point(194, 188);
            this.reghNotextBox.Name = "reghNotextBox";
            this.reghNotextBox.Size = new System.Drawing.Size(158, 20);
            this.reghNotextBox.TabIndex = 8;
            // 
            // depidtextBox
            // 
            this.depidtextBox.Location = new System.Drawing.Point(194, 223);
            this.depidtextBox.Name = "depidtextBox";
            this.depidtextBox.Size = new System.Drawing.Size(158, 20);
            this.depidtextBox.TabIndex = 9;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(163, 262);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 10;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 291);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(638, 189);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(275, 262);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(77, 23);
            this.showbutton.TabIndex = 12;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(386, 147);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(479, 147);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id";
            // 
            // serchText
            // 
            this.serchText.Location = new System.Drawing.Point(449, 92);
            this.serchText.Name = "serchText";
            this.serchText.Size = new System.Drawing.Size(136, 20);
            this.serchText.TabIndex = 16;
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(575, 147);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(75, 23);
            this.findbutton.TabIndex = 17;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 492);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.serchText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.depidtextBox);
            this.Controls.Add(this.reghNotextBox);
            this.Controls.Add(this.contacttextBox);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.TextBox contacttextBox;
        private System.Windows.Forms.TextBox reghNotextBox;
        private System.Windows.Forms.TextBox depidtextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serchText;
        private System.Windows.Forms.Button findbutton;
    }
}

