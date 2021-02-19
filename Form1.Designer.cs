
namespace csharp_vathmologoumeni_3
{
    partial class FormMainMenu
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelHorizontalLine = new System.Windows.Forms.Label();
            this.pictureBoxUnipi = new System.Windows.Forms.PictureBox();
            this.labelStudents = new System.Windows.Forms.Label();
            this.buttonSkakiera = new System.Windows.Forms.Button();
            this.buttonMemoryGame = new System.Windows.Forms.Button();
            this.buttonCovid = new System.Windows.Forms.Button();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemoryGameItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChessGameItem = new System.Windows.Forms.ToolStripMenuItem();
            this.COVID19WebsiteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(538, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(241, 36);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Selections Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1333, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelHorizontalLine
            // 
            this.labelHorizontalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHorizontalLine.Location = new System.Drawing.Point(12, 146);
            this.labelHorizontalLine.Name = "labelHorizontalLine";
            this.labelHorizontalLine.Size = new System.Drawing.Size(1309, 2);
            this.labelHorizontalLine.TabIndex = 2;
            // 
            // pictureBoxUnipi
            // 
            this.pictureBoxUnipi.Image = global::csharp_vathmologoumeni_3.Properties.Resources.unipi2;
            this.pictureBoxUnipi.Location = new System.Drawing.Point(12, 34);
            this.pictureBoxUnipi.Name = "pictureBoxUnipi";
            this.pictureBoxUnipi.Size = new System.Drawing.Size(358, 95);
            this.pictureBoxUnipi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUnipi.TabIndex = 3;
            this.pictureBoxUnipi.TabStop = false;
            // 
            // labelStudents
            // 
            this.labelStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudents.AutoSize = true;
            this.labelStudents.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudents.Location = new System.Drawing.Point(1022, 41);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelStudents.Size = new System.Drawing.Size(299, 84);
            this.labelStudents.TabIndex = 4;
            this.labelStudents.Text = "Π19032 - Nikos Georgiadis\r\nΠ19085 - Lefteris Lambrakos\r\nΠ19204 - Giorgos Seimenis" +
    "";
            // 
            // buttonSkakiera
            // 
            this.buttonSkakiera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSkakiera.AutoSize = true;
            this.buttonSkakiera.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSkakiera.Location = new System.Drawing.Point(502, 297);
            this.buttonSkakiera.Name = "buttonSkakiera";
            this.buttonSkakiera.Size = new System.Drawing.Size(307, 73);
            this.buttonSkakiera.TabIndex = 5;
            this.buttonSkakiera.Text = "Chess Game";
            this.buttonSkakiera.UseVisualStyleBackColor = true;
            this.buttonSkakiera.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // buttonMemoryGame
            // 
            this.buttonMemoryGame.AutoSize = true;
            this.buttonMemoryGame.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMemoryGame.Location = new System.Drawing.Point(12, 297);
            this.buttonMemoryGame.Name = "buttonMemoryGame";
            this.buttonMemoryGame.Size = new System.Drawing.Size(307, 73);
            this.buttonMemoryGame.TabIndex = 6;
            this.buttonMemoryGame.Text = "Memory Game ";
            this.buttonMemoryGame.UseVisualStyleBackColor = true;
            this.buttonMemoryGame.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // buttonCovid
            // 
            this.buttonCovid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCovid.AutoSize = true;
            this.buttonCovid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCovid.Location = new System.Drawing.Point(1014, 297);
            this.buttonCovid.Name = "buttonCovid";
            this.buttonCovid.Size = new System.Drawing.Size(307, 73);
            this.buttonCovid.TabIndex = 7;
            this.buttonCovid.Text = "COVID-19 Website";
            this.buttonCovid.UseVisualStyleBackColor = true;
            this.buttonCovid.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.Location = new System.Drawing.Point(538, 164);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(704, 26);
            this.labelSubtitle.TabIndex = 8;
            this.labelSubtitle.Text = "You will be lead to a different app by clicking any of the buttons below.";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MemoryGameItem,
            this.ChessGameItem,
            this.COVID19WebsiteItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MemoryGameItem
            // 
            this.MemoryGameItem.Name = "MemoryGameItem";
            this.MemoryGameItem.Size = new System.Drawing.Size(180, 22);
            this.MemoryGameItem.Text = "Memory Game";
            this.MemoryGameItem.Click += new System.EventHandler(this.AnyToolStripItemClicked);
            // 
            // ChessGameItem
            // 
            this.ChessGameItem.Name = "ChessGameItem";
            this.ChessGameItem.Size = new System.Drawing.Size(180, 22);
            this.ChessGameItem.Text = "Chess Game";
            this.ChessGameItem.Click += new System.EventHandler(this.AnyToolStripItemClicked);
            // 
            // COVID19WebsiteItem
            // 
            this.COVID19WebsiteItem.Name = "COVID19WebsiteItem";
            this.COVID19WebsiteItem.Size = new System.Drawing.Size(180, 22);
            this.COVID19WebsiteItem.Text = "COVID-19 Website";
            this.COVID19WebsiteItem.Click += new System.EventHandler(this.AnyToolStripItemClicked);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1333, 613);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.buttonCovid);
            this.Controls.Add(this.buttonMemoryGame);
            this.Controls.Add(this.buttonSkakiera);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.pictureBoxUnipi);
            this.Controls.Add(this.labelHorizontalLine);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Κύριο Μενού";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelHorizontalLine;
        private System.Windows.Forms.PictureBox pictureBoxUnipi;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Button buttonSkakiera;
        private System.Windows.Forms.Button buttonMemoryGame;
        private System.Windows.Forms.Button buttonCovid;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemoryGameItem;
        private System.Windows.Forms.ToolStripMenuItem ChessGameItem;
        private System.Windows.Forms.ToolStripMenuItem COVID19WebsiteItem;
    }
}

