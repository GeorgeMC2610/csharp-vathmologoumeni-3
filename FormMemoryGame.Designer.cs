
namespace csharp_vathmologoumeni_3
{
    partial class FormMemoryGame
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.Player_Name = new System.Windows.Forms.Label();
            this.Memory_Game_picture = new System.Windows.Forms.PictureBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkedLabelLeaderboard = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Memory_Game_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReturnToMenu
            // 
            this.buttonReturnToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturnToMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonReturnToMenu.ForeColor = System.Drawing.Color.Red;
            this.buttonReturnToMenu.Location = new System.Drawing.Point(902, 11);
            this.buttonReturnToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonReturnToMenu.Name = "buttonReturnToMenu";
            this.buttonReturnToMenu.Size = new System.Drawing.Size(101, 47);
            this.buttonReturnToMenu.TabIndex = 6;
            this.buttonReturnToMenu.Text = "Return to main menu";
            this.buttonReturnToMenu.UseVisualStyleBackColor = false;
            this.buttonReturnToMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(12, 38);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(135, 23);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // Player_Name
            // 
            this.Player_Name.AutoSize = true;
            this.Player_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Name.Location = new System.Drawing.Point(12, 18);
            this.Player_Name.Name = "Player_Name";
            this.Player_Name.Size = new System.Drawing.Size(60, 15);
            this.Player_Name.TabIndex = 99;
            this.Player_Name.Text = "Username";
            // 
            // Memory_Game_picture
            // 
            this.Memory_Game_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Memory_Game_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Memory_Game_picture.Image = global::csharp_vathmologoumeni_3.Properties.Resources.Memory_Game;
            this.Memory_Game_picture.Location = new System.Drawing.Point(12, 65);
            this.Memory_Game_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Memory_Game_picture.Name = "Memory_Game_picture";
            this.Memory_Game_picture.Size = new System.Drawing.Size(988, 454);
            this.Memory_Game_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Memory_Game_picture.TabIndex = 3;
            this.Memory_Game_picture.TabStop = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlay.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlay.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Red;
            this.buttonPlay.Location = new System.Drawing.Point(442, 11);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(130, 47);
            this.buttonPlay.TabIndex = 4;
            this.buttonPlay.Text = "Lets Play!";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMinutes.Location = new System.Drawing.Point(186, 38);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownMinutes.TabIndex = 3;
            this.numericUpDownMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(186, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 19);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Countdown Timer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkedLabelLeaderboard
            // 
            this.linkedLabelLeaderboard.AutoSize = true;
            this.linkedLabelLeaderboard.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkedLabelLeaderboard.Location = new System.Drawing.Point(687, 32);
            this.linkedLabelLeaderboard.Name = "linkedLabelLeaderboard";
            this.linkedLabelLeaderboard.Size = new System.Drawing.Size(127, 25);
            this.linkedLabelLeaderboard.TabIndex = 5;
            this.linkedLabelLeaderboard.TabStop = true;
            this.linkedLabelLeaderboard.Text = "Leaderboards";
            // 
            // FormMemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 530);
            this.Controls.Add(this.linkedLabelLeaderboard);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.Memory_Game_picture);
            this.Controls.Add(this.Player_Name);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonReturnToMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMemoryGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMemoryGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMemoryGame_FormClosed);
            this.Load += new System.EventHandler(this.FormMemoryGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Memory_Game_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnToMenu;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label Player_Name;
        private System.Windows.Forms.PictureBox Memory_Game_picture;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkedLabelLeaderboard;
    }
}