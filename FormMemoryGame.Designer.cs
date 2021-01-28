
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Memory_Game_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(673, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Return to main menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Player_Name
            // 
            this.Player_Name.AutoSize = true;
            this.Player_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Player_Name.Location = new System.Drawing.Point(9, 20);
            this.Player_Name.Name = "Player_Name";
            this.Player_Name.Size = new System.Drawing.Size(117, 18);
            this.Player_Name.TabIndex = 2;
            this.Player_Name.Text = "Enter user name";
            // 
            // Memory_Game_picture
            // 
            this.Memory_Game_picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Memory_Game_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Memory_Game_picture.Image = global::csharp_vathmologoumeni_3.Properties.Resources.Memory_Game;
            this.Memory_Game_picture.Location = new System.Drawing.Point(12, 69);
            this.Memory_Game_picture.Name = "Memory_Game_picture";
            this.Memory_Game_picture.Size = new System.Drawing.Size(776, 369);
            this.Memory_Game_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Memory_Game_picture.TabIndex = 3;
            this.Memory_Game_picture.TabStop = false;
            // 
            // LeaderBoard
            // 
            this.LeaderBoard.AutoSize = true;
            this.LeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LeaderBoard.Location = new System.Drawing.Point(500, 38);
            this.LeaderBoard.Name = "LeaderBoard";
            this.LeaderBoard.Size = new System.Drawing.Size(106, 20);
            this.LeaderBoard.TabIndex = 4;
            this.LeaderBoard.Text = "LeaderBoard";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.button2.Location = new System.Drawing.Point(147, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Free Play";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.button3.Location = new System.Drawing.Point(237, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Play Time";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormMemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LeaderBoard);
            this.Controls.Add(this.Memory_Game_picture);
            this.Controls.Add(this.Player_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormMemoryGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMemoryGame";
            ((System.ComponentModel.ISupportInitialize)(this.Memory_Game_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Player_Name;
        private System.Windows.Forms.PictureBox Memory_Game_picture;
        private System.Windows.Forms.Label LeaderBoard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}