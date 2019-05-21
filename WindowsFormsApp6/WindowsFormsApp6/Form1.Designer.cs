namespace WindowsFormsApp6
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
            this.firstNametextbox = new System.Windows.Forms.TextBox();
            this.middleNametext = new System.Windows.Forms.TextBox();
            this.lastNametextbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.nameList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Middle Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Las name";
            // 
            // firstNametextbox
            // 
            this.firstNametextbox.Location = new System.Drawing.Point(287, 64);
            this.firstNametextbox.Name = "firstNametextbox";
            this.firstNametextbox.Size = new System.Drawing.Size(135, 20);
            this.firstNametextbox.TabIndex = 3;
            // 
            // middleNametext
            // 
            this.middleNametext.Location = new System.Drawing.Point(287, 104);
            this.middleNametext.Name = "middleNametext";
            this.middleNametext.Size = new System.Drawing.Size(135, 20);
            this.middleNametext.TabIndex = 4;
            // 
            // lastNametextbox
            // 
            this.lastNametextbox.Location = new System.Drawing.Point(287, 138);
            this.lastNametextbox.Name = "lastNametextbox";
            this.lastNametextbox.Size = new System.Drawing.Size(135, 20);
            this.lastNametextbox.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(368, 175);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Show";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameList
            // 
            this.nameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.nameList.GridLines = true;
            this.nameList.Location = new System.Drawing.Point(121, 214);
            this.nameList.Name = "nameList";
            this.nameList.Size = new System.Drawing.Size(371, 168);
            this.nameList.TabIndex = 7;
            this.nameList.UseCompatibleStateImageBehavior = false;
            this.nameList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Full Name";
            this.columnHeader1.Width = 209;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(287, 175);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 8;
            this.showButton.Text = "save";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.nameList);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.lastNametextbox);
            this.Controls.Add(this.middleNametext);
            this.Controls.Add(this.firstNametextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNametextbox;
        private System.Windows.Forms.TextBox middleNametext;
        private System.Windows.Forms.TextBox lastNametextbox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ListView nameList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button showButton;
    }
}

