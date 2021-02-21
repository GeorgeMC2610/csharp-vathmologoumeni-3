
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Player_Name = new System.Windows.Forms.Label();
            this.Memory_Game_picture = new System.Windows.Forms.PictureBox();
            this.LeaderBoard = new System.Windows.Forms.Label();
            this.Lets_Play = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Memory_Game_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(902, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return to main menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 23);
            this.textBox1.TabIndex = 1;
            // 
            // Player_Name
            // 
            this.Player_Name.AutoSize = true;
            this.Player_Name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Name.Location = new System.Drawing.Point(12, 18);
            this.Player_Name.Name = "Player_Name";
            this.Player_Name.Size = new System.Drawing.Size(60, 15);
            this.Player_Name.TabIndex = 2;
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
            // LeaderBoard
            // 
            this.LeaderBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeaderBoard.AutoSize = true;
            this.LeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LeaderBoard.Location = new System.Drawing.Point(696, 36);
            this.LeaderBoard.Name = "LeaderBoard";
            this.LeaderBoard.Size = new System.Drawing.Size(91, 17);
            this.LeaderBoard.TabIndex = 4;
            this.LeaderBoard.Text = "LeaderBoard";
            // 
            // Lets_Play
            // 
            this.Lets_Play.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lets_Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lets_Play.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lets_Play.ForeColor = System.Drawing.Color.Red;
            this.Lets_Play.Location = new System.Drawing.Point(442, 11);
            this.Lets_Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lets_Play.Name = "Lets_Play";
            this.Lets_Play.Size = new System.Drawing.Size(130, 47);
            this.Lets_Play.TabIndex = 7;
            this.Lets_Play.Text = "Lets Play!";
            this.Lets_Play.UseVisualStyleBackColor = true;
            this.Lets_Play.Click += new System.EventHandler(this.Lets_Play_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(153, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(153, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Countdown Timer";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormMemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 530);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Lets_Play);
            this.Controls.Add(this.LeaderBoard);
            this.Controls.Add(this.Memory_Game_picture);
            this.Controls.Add(this.Player_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMemoryGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMemoryGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMemoryGame_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Memory_Game_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Player_Name;
        private System.Windows.Forms.PictureBox Memory_Game_picture;
        private System.Windows.Forms.Label LeaderBoard;
        private System.Windows.Forms.Button Lets_Play;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}