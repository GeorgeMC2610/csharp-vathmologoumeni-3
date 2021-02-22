namespace csharp_vathmologoumeni_3
{
    partial class MemoryGame_Leaderboard
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
            this.buttonReturnToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturnToMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonReturnToMenu.ForeColor = System.Drawing.Color.Red;
            this.buttonReturnToMenu.Location = new System.Drawing.Point(661, 11);
            this.buttonReturnToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(127, 58);
            this.buttonReturnToMenu.TabIndex = 7;
            this.buttonReturnToMenu.Text = "Return to menu";
            this.buttonReturnToMenu.UseVisualStyleBackColor = false;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // MemoryGame_Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Name = "MemoryGame_Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemoryGame_Leaderboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnToMenu;
    }
}