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
            this.richTextBoxLeaderboards = new System.Windows.Forms.RichTextBox();
            this.labelTopPlayers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturnToMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonReturnToMenu.ForeColor = System.Drawing.Color.Red;
            this.buttonReturnToMenu.Location = new System.Drawing.Point(943, 19);
            this.buttonReturnToMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(111, 45);
            this.buttonReturnToMenu.TabIndex = 7;
            this.buttonReturnToMenu.Text = "Return to menu";
            this.buttonReturnToMenu.UseVisualStyleBackColor = false;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.buttonReturnToMenu_Click);
            // 
            // richTextBoxLeaderboards
            // 
            this.richTextBoxLeaderboards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLeaderboards.Location = new System.Drawing.Point(12, 69);
            this.richTextBoxLeaderboards.Name = "richTextBoxLeaderboards";
            this.richTextBoxLeaderboards.ReadOnly = true;
            this.richTextBoxLeaderboards.Size = new System.Drawing.Size(1042, 463);
            this.richTextBoxLeaderboards.TabIndex = 8;
            this.richTextBoxLeaderboards.Text = "";
            // 
            // labelTopPlayers
            // 
            this.labelTopPlayers.AutoSize = true;
            this.labelTopPlayers.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopPlayers.Location = new System.Drawing.Point(4, 21);
            this.labelTopPlayers.Name = "labelTopPlayers";
            this.labelTopPlayers.Size = new System.Drawing.Size(391, 45);
            this.labelTopPlayers.TabIndex = 9;
            this.labelTopPlayers.Text = "Top Players Leaderboard";
            // 
            // MemoryGame_Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 544);
            this.Controls.Add(this.labelTopPlayers);
            this.Controls.Add(this.richTextBoxLeaderboards);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MemoryGame_Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemoryGame_Leaderboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemoryGame_Leaderboard_FormClosed);
            this.Load += new System.EventHandler(this.MemoryGame_Leaderboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnToMenu;
        private System.Windows.Forms.RichTextBox richTextBoxLeaderboards;
        private System.Windows.Forms.Label labelTopPlayers;
    }
}