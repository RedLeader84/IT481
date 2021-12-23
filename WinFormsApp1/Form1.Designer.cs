
using System;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckConnectionLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CountButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckConnectionLabel
            // 
            this.CheckConnectionLabel.AutoSize = true;
            this.CheckConnectionLabel.Location = new System.Drawing.Point(1182, 37);
            this.CheckConnectionLabel.Name = "CheckConnectionLabel";
            this.CheckConnectionLabel.Size = new System.Drawing.Size(243, 32);
            this.CheckConnectionLabel.TabIndex = 0;
            this.CheckConnectionLabel.Text = "Connection Checking";
            this.CheckConnectionLabel.Click += new System.EventHandler(this.CheckConnectionLabel_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(538, 75);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(210, 46);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update Database";
            this.UpdateButton.UseVisualStyleBackColor = true;
            using (Form1 Form1 = this)
            {
                Form1.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            }
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(1713, 130);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(182, 46);
            this.CountButton.TabIndex = 2;
            this.CountButton.Text = "Count Records";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(911, 1063);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(190, 46);
            this.ViewButton.TabIndex = 3;
            this.ViewButton.Text = "View Database";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(105, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1790, 714);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 39);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 39);
            this.textBox2.TabIndex = 6;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(23, 40);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(37, 32);
            this.IdLabel.TabIndex = 7;
            this.IdLabel.Text = "ID";
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(23, 107);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(187, 32);
            this.CompanyLabel.TabIndex = 8;
            this.CompanyLabel.Text = "Company Name";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(1592, 130);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(79, 32);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "Count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2263, 1146);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CheckConnectionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CheckConnectionLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label CheckConnectionLabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label lblCount;
    }
}

