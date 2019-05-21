namespace WindowsFormsApp2
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fatherNameTextbox = new System.Windows.Forms.TextBox();
            this.motherNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.infoShowButton = new System.Windows.Forms.Button();
            this.bullNameshow = new System.Windows.Forms.Button();
            this.fatherandMotherName = new System.Windows.Forms.Button();
            this.addressShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(236, 60);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(270, 20);
            this.firstNameTextbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(236, 99);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(270, 20);
            this.lastNameTextbox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Father\'s Name";
            // 
            // fatherNameTextbox
            // 
            this.fatherNameTextbox.Location = new System.Drawing.Point(236, 135);
            this.fatherNameTextbox.Name = "fatherNameTextbox";
            this.fatherNameTextbox.Size = new System.Drawing.Size(270, 20);
            this.fatherNameTextbox.TabIndex = 3;
            // 
            // motherNameTextbox
            // 
            this.motherNameTextbox.Location = new System.Drawing.Point(236, 176);
            this.motherNameTextbox.Name = "motherNameTextbox";
            this.motherNameTextbox.Size = new System.Drawing.Size(270, 20);
            this.motherNameTextbox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mother\'s Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(236, 209);
            this.addressTextbox.Multiline = true;
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(270, 85);
            this.addressTextbox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(236, 314);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoShowButton
            // 
            this.infoShowButton.Location = new System.Drawing.Point(349, 313);
            this.infoShowButton.Name = "infoShowButton";
            this.infoShowButton.Size = new System.Drawing.Size(157, 23);
            this.infoShowButton.TabIndex = 7;
            this.infoShowButton.Text = "Show All information";
            this.infoShowButton.UseVisualStyleBackColor = true;
            this.infoShowButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // bullNameshow
            // 
            this.bullNameshow.Location = new System.Drawing.Point(236, 359);
            this.bullNameshow.Name = "bullNameshow";
            this.bullNameshow.Size = new System.Drawing.Size(75, 23);
            this.bullNameshow.TabIndex = 8;
            this.bullNameshow.Text = "Full Name";
            this.bullNameshow.UseVisualStyleBackColor = true;
            this.bullNameshow.Click += new System.EventHandler(this.bullNameshow_Click);
            // 
            // fatherandMotherName
            // 
            this.fatherandMotherName.Location = new System.Drawing.Point(317, 359);
            this.fatherandMotherName.Name = "fatherandMotherName";
            this.fatherandMotherName.Size = new System.Drawing.Size(92, 23);
            this.fatherandMotherName.TabIndex = 9;
            this.fatherandMotherName.Text = "Parent\'s Name";
            this.fatherandMotherName.UseVisualStyleBackColor = true;
            // 
            // addressShow
            // 
            this.addressShow.Location = new System.Drawing.Point(415, 359);
            this.addressShow.Name = "addressShow";
            this.addressShow.Size = new System.Drawing.Size(91, 23);
            this.addressShow.TabIndex = 10;
            this.addressShow.Text = "Address";
            this.addressShow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.addressShow);
            this.Controls.Add(this.fatherandMotherName);
            this.Controls.Add(this.bullNameshow);
            this.Controls.Add(this.infoShowButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.motherNameTextbox);
            this.Controls.Add(this.fatherNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fatherNameTextbox;
        private System.Windows.Forms.TextBox motherNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button infoShowButton;
        private System.Windows.Forms.Button bullNameshow;
        private System.Windows.Forms.Button fatherandMotherName;
        private System.Windows.Forms.Button addressShow;
    }
}

