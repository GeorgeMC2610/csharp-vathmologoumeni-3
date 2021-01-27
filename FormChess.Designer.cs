
namespace csharp_vathmologoumeni_3
{
    partial class FormChess
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBoxPlayer1Nickname = new System.Windows.Forms.TextBox();
            this.labelFirstNickname = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlayer2Nickname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxTimers = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelTimers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Font = new System.Drawing.Font("Helvetica Rounded", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1106, 27);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(133, 35);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit to Main Menu";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBoxPlayer1Nickname
            // 
            this.textBoxPlayer1Nickname.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer1Nickname.Location = new System.Drawing.Point(458, 190);
            this.textBoxPlayer1Nickname.MaxLength = 45;
            this.textBoxPlayer1Nickname.Name = "textBoxPlayer1Nickname";
            this.textBoxPlayer1Nickname.Size = new System.Drawing.Size(282, 30);
            this.textBoxPlayer1Nickname.TabIndex = 2;
            // 
            // labelFirstNickname
            // 
            this.labelFirstNickname.AutoSize = true;
            this.labelFirstNickname.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNickname.Location = new System.Drawing.Point(454, 168);
            this.labelFirstNickname.Name = "labelFirstNickname";
            this.labelFirstNickname.Size = new System.Drawing.Size(167, 19);
            this.labelFirstNickname.TabIndex = 3;
            this.labelFirstNickname.Text = "Player 1\'s Nickname";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(359, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(519, 32);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Welcome! Ready to play some Chess?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type your nicknames in order to begin!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player 2\'s Nickname";
            // 
            // textBoxPlayer2Nickname
            // 
            this.textBoxPlayer2Nickname.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer2Nickname.Location = new System.Drawing.Point(458, 302);
            this.textBoxPlayer2Nickname.MaxLength = 45;
            this.textBoxPlayer2Nickname.Name = "textBoxPlayer2Nickname";
            this.textBoxPlayer2Nickname.Size = new System.Drawing.Size(282, 30);
            this.textBoxPlayer2Nickname.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(458, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "Play!";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // checkBoxTimers
            // 
            this.checkBoxTimers.AutoSize = true;
            this.checkBoxTimers.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTimers.Location = new System.Drawing.Point(824, 197);
            this.checkBoxTimers.Name = "checkBoxTimers";
            this.checkBoxTimers.Size = new System.Drawing.Size(133, 21);
            this.checkBoxTimers.TabIndex = 9;
            this.checkBoxTimers.Text = "Include Timers";
            this.checkBoxTimers.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(824, 305);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 26);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelTimers
            // 
            this.labelTimers.AutoSize = true;
            this.labelTimers.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimers.Location = new System.Drawing.Point(820, 283);
            this.labelTimers.Name = "labelTimers";
            this.labelTimers.Size = new System.Drawing.Size(167, 19);
            this.labelTimers.TabIndex = 11;
            this.labelTimers.Text = "Time for each player";
            // 
            // FormChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 631);
            this.Controls.Add(this.labelTimers);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBoxTimers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlayer2Nickname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelFirstNickname);
            this.Controls.Add(this.textBoxPlayer1Nickname);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChess";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBoxPlayer1Nickname;
        private System.Windows.Forms.Label labelFirstNickname;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlayer2Nickname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxTimers;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelTimers;
    }
}