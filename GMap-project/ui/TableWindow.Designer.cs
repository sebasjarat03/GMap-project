﻿
namespace GMap_project.ui
{
    partial class TableWindow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fieldBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parameterBox = new System.Windows.Forms.ComboBox();
            this.placeName = new System.Windows.Forms.TextBox();
            this.clearFiltersButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(813, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // fieldBox
            // 
            this.fieldBox.FormattingEnabled = true;
            this.fieldBox.Location = new System.Drawing.Point(883, 39);
            this.fieldBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fieldBox.Name = "fieldBox";
            this.fieldBox.Size = new System.Drawing.Size(271, 24);
            this.fieldBox.TabIndex = 1;
            this.fieldBox.SelectedIndexChanged += new System.EventHandler(this.fieldBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(883, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a field:";
            // 
            // parameterBox
            // 
            this.parameterBox.FormattingEnabled = true;
            this.parameterBox.Location = new System.Drawing.Point(883, 86);
            this.parameterBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parameterBox.Name = "parameterBox";
            this.parameterBox.Size = new System.Drawing.Size(267, 24);
            this.parameterBox.TabIndex = 3;
            this.parameterBox.Visible = false;
            this.parameterBox.SelectedIndexChanged += new System.EventHandler(this.parameterBox_SelectedIndexChanged);
            // 
            // placeName
            // 
            this.placeName.Location = new System.Drawing.Point(883, 86);
            this.placeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeName.Name = "placeName";
            this.placeName.Size = new System.Drawing.Size(253, 22);
            this.placeName.TabIndex = 4;
            this.placeName.Visible = false;
            this.placeName.TextChanged += new System.EventHandler(this.placeName_TextChanged);
            // 
            // clearFiltersButt
            // 
            this.clearFiltersButt.Location = new System.Drawing.Point(963, 129);
            this.clearFiltersButt.Name = "clearFiltersButt";
            this.clearFiltersButt.Size = new System.Drawing.Size(94, 40);
            this.clearFiltersButt.TabIndex = 5;
            this.clearFiltersButt.Text = "Clear filters";
            this.clearFiltersButt.UseVisualStyleBackColor = true;
            this.clearFiltersButt.Click += new System.EventHandler(this.clearFiltersButt_Click);
            // 
            // TableWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 551);
            this.Controls.Add(this.clearFiltersButt);
            this.Controls.Add(this.placeName);
            this.Controls.Add(this.parameterBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fieldBox);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TableWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox fieldBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox parameterBox;
        private System.Windows.Forms.TextBox placeName;
        private System.Windows.Forms.Button clearFiltersButt;
    }
}