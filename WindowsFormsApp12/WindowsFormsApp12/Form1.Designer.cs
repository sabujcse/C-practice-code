namespace WindowsFormsApp12
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
            this.codetextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.coureidtextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.showButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.findbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CouresId";
            // 
            // codetextBox
            // 
            this.codetextBox.Location = new System.Drawing.Point(131, 77);
            this.codetextBox.Name = "codetextBox";
            this.codetextBox.Size = new System.Drawing.Size(139, 20);
            this.codetextBox.TabIndex = 4;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(131, 119);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(139, 20);
            this.nametextBox.TabIndex = 5;
            // 
            // coureidtextBox
            // 
            this.coureidtextBox.Location = new System.Drawing.Point(131, 158);
            this.coureidtextBox.Name = "coureidtextBox";
            this.coureidtextBox.Size = new System.Drawing.Size(139, 20);
            this.coureidtextBox.TabIndex = 6;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(173, 194);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 7;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 234);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(689, 204);
            this.dataGridView.TabIndex = 8;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(274, 194);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Inser Id";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(332, 25);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(112, 20);
            this.searchtextBox.TabIndex = 11;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(276, 60);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 12;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(357, 60);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // findbutton
            // 
            this.findbutton.Location = new System.Drawing.Point(441, 60);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(75, 23);
            this.findbutton.TabIndex = 14;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 447);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.coureidtextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.codetextBox);
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
        private System.Windows.Forms.TextBox codetextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox coureidtextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button findbutton;
    }
}

