﻿namespace csharp_vathmologoumeni_3
{
    partial class Choose_covid_db_option
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
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCovidCaseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndModifyCovidCaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome employee!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(275, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 66);
            this.button3.TabIndex = 5;
            this.button3.Text = "Visit covid case reports website";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.aboutTheApplicationToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 27);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCovidCaseReportToolStripMenuItem,
            this.searchAndModifyCovidCaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // addCovidCaseReportToolStripMenuItem
            // 
            this.addCovidCaseReportToolStripMenuItem.Name = "addCovidCaseReportToolStripMenuItem";
            this.addCovidCaseReportToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.addCovidCaseReportToolStripMenuItem.Text = "Add a covid case report";
            this.addCovidCaseReportToolStripMenuItem.Click += new System.EventHandler(this.addCovidCaseReportToolStripMenuItem_Click);
            // 
            // searchAndModifyCovidCaseToolStripMenuItem
            // 
            this.searchAndModifyCovidCaseToolStripMenuItem.Name = "searchAndModifyCovidCaseToolStripMenuItem";
            this.searchAndModifyCovidCaseToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.searchAndModifyCovidCaseToolStripMenuItem.Text = "Search and modify a covid case report ";
            this.searchAndModifyCovidCaseToolStripMenuItem.Click += new System.EventHandler(this.searchAndModifyCovidCaseToolStripMenuItem_Click);
            // 
            // aboutTheApplicationToolStripMenuItem
            // 
            this.aboutTheApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.aboutTheApplicationToolStripMenuItem.Name = "aboutTheApplicationToolStripMenuItem";
            this.aboutTheApplicationToolStripMenuItem.Size = new System.Drawing.Size(166, 23);
            this.aboutTheApplicationToolStripMenuItem.Text = "About the application";
            this.aboutTheApplicationToolStripMenuItem.Click += new System.EventHandler(this.aboutTheApplicationToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Choose_covid_db_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 464);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Choose_covid_db_option";
            this.Text = "Covid case reports application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Choose_covid_db_option_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCovidCaseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAndModifyCovidCaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}