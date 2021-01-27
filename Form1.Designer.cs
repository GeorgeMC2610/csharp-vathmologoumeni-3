
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelHorizontalLine = new System.Windows.Forms.Label();
            this.pictureBoxUnipi = new System.Windows.Forms.PictureBox();
            this.labelStudents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(538, 34);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(241, 36);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Selections Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
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
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 613);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.pictureBoxUnipi);
            this.Controls.Add(this.labelHorizontalLine);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMainMenu";
            this.Text = "Κύριο Μενού";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUnipi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelHorizontalLine;
        private System.Windows.Forms.PictureBox pictureBoxUnipi;
        private System.Windows.Forms.Label labelStudents;
    }
}

