﻿namespace MINTAVIZSGAC
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
            this.BooksGrid = new System.Windows.Forms.DataGridView();
            this.deletebutton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publish_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksGrid
            // 
            this.BooksGrid.AllowUserToAddRows = false;
            this.BooksGrid.AllowUserToDeleteRows = false;
            this.BooksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.author,
            this.publish_year,
            this.page_count});
            this.BooksGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BooksGrid.Location = new System.Drawing.Point(0, 46);
            this.BooksGrid.MultiSelect = false;
            this.BooksGrid.Name = "BooksGrid";
            this.BooksGrid.ReadOnly = true;
            this.BooksGrid.RowHeadersWidth = 51;
            this.BooksGrid.RowTemplate.Height = 24;
            this.BooksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksGrid.Size = new System.Drawing.Size(800, 404);
            this.BooksGrid.TabIndex = 0;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(43, 12);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(95, 28);
            this.deletebutton.TabIndex = 1;
            this.deletebutton.Text = "Törlés";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "Cím";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 200;
            // 
            // author
            // 
            this.author.DataPropertyName = "Author";
            this.author.HeaderText = "Szerző";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 150;
            // 
            // publish_year
            // 
            this.publish_year.DataPropertyName = "Publish_year";
            this.publish_year.HeaderText = "Kiadás éve";
            this.publish_year.MinimumWidth = 6;
            this.publish_year.Name = "publish_year";
            this.publish_year.ReadOnly = true;
            this.publish_year.Width = 125;
            // 
            // page_count
            // 
            this.page_count.DataPropertyName = "Page_count";
            this.page_count.HeaderText = "Oldalszám";
            this.page_count.MinimumWidth = 6;
            this.page_count.Name = "page_count";
            this.page_count.ReadOnly = true;
            this.page_count.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.BooksGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksGrid;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publish_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn page_count;
    }
}

