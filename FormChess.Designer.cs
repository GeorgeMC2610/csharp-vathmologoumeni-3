
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
            this.labelSecondNickname = new System.Windows.Forms.Label();
            this.textBoxPlayer2Nickname = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.checkBoxTimers = new System.Windows.Forms.CheckBox();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.labelTimers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.textBoxPlayer1Nickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPlayer1Nickname.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer1Nickname.Location = new System.Drawing.Point(365, 190);
            this.textBoxPlayer1Nickname.MaxLength = 45;
            this.textBoxPlayer1Nickname.Name = "textBoxPlayer1Nickname";
            this.textBoxPlayer1Nickname.Size = new System.Drawing.Size(282, 30);
            this.textBoxPlayer1Nickname.TabIndex = 2;
            this.textBoxPlayer1Nickname.Tag = "PreLogin";
            this.textBoxPlayer1Nickname.TextChanged += new System.EventHandler(this.PreLoginControls_Changed);
            // 
            // labelFirstNickname
            // 
            this.labelFirstNickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFirstNickname.AutoSize = true;
            this.labelFirstNickname.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstNickname.Location = new System.Drawing.Point(361, 168);
            this.labelFirstNickname.Name = "labelFirstNickname";
            this.labelFirstNickname.Size = new System.Drawing.Size(167, 19);
            this.labelFirstNickname.TabIndex = 3;
            this.labelFirstNickname.Tag = "PreLogin";
            this.labelFirstNickname.Text = "Player 1\'s Nickname";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Helvetica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(359, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(519, 32);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Tag = "PreLogin";
            this.labelTitle.Text = "Welcome! Ready to play some Chess?";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 28);
            this.label1.TabIndex = 5;
            this.label1.Tag = "PreLogin";
            this.label1.Text = "Type your nicknames in order to begin!";
            // 
            // labelSecondNickname
            // 
            this.labelSecondNickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSecondNickname.AutoSize = true;
            this.labelSecondNickname.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondNickname.Location = new System.Drawing.Point(361, 280);
            this.labelSecondNickname.Name = "labelSecondNickname";
            this.labelSecondNickname.Size = new System.Drawing.Size(167, 19);
            this.labelSecondNickname.TabIndex = 7;
            this.labelSecondNickname.Tag = "PreLogin";
            this.labelSecondNickname.Text = "Player 2\'s Nickname";
            // 
            // textBoxPlayer2Nickname
            // 
            this.textBoxPlayer2Nickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPlayer2Nickname.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer2Nickname.Location = new System.Drawing.Point(365, 302);
            this.textBoxPlayer2Nickname.MaxLength = 45;
            this.textBoxPlayer2Nickname.Name = "textBoxPlayer2Nickname";
            this.textBoxPlayer2Nickname.Size = new System.Drawing.Size(282, 30);
            this.textBoxPlayer2Nickname.TabIndex = 6;
            this.textBoxPlayer2Nickname.Tag = "PreLogin";
            this.textBoxPlayer2Nickname.TextChanged += new System.EventHandler(this.PreLoginControls_Changed);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStartGame.BackColor = System.Drawing.Color.Green;
            this.buttonStartGame.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.ForeColor = System.Drawing.Color.White;
            this.buttonStartGame.Location = new System.Drawing.Point(365, 566);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(513, 53);
            this.buttonStartGame.TabIndex = 8;
            this.buttonStartGame.Tag = "PreLogin";
            this.buttonStartGame.Text = "Play!";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.AnyButtonClicked);
            // 
            // checkBoxTimers
            // 
            this.checkBoxTimers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxTimers.AutoSize = true;
            this.checkBoxTimers.Checked = true;
            this.checkBoxTimers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTimers.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTimers.Location = new System.Drawing.Point(745, 195);
            this.checkBoxTimers.Name = "checkBoxTimers";
            this.checkBoxTimers.Size = new System.Drawing.Size(133, 21);
            this.checkBoxTimers.TabIndex = 9;
            this.checkBoxTimers.Tag = "PreLogin";
            this.checkBoxTimers.Text = "Include Timers";
            this.checkBoxTimers.UseVisualStyleBackColor = true;
            this.checkBoxTimers.CheckedChanged += new System.EventHandler(this.PreLoginControls_Changed);
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownMinutes.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMinutes.Location = new System.Drawing.Point(745, 305);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownMinutes.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(130, 26);
            this.numericUpDownMinutes.TabIndex = 10;
            this.numericUpDownMinutes.Tag = "PreLogin";
            this.numericUpDownMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMinutes.ValueChanged += new System.EventHandler(this.PreLoginControls_Changed);
            // 
            // labelTimers
            // 
            this.labelTimers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTimers.AutoSize = true;
            this.labelTimers.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimers.Location = new System.Drawing.Point(741, 283);
            this.labelTimers.Name = "labelTimers";
            this.labelTimers.Size = new System.Drawing.Size(167, 19);
            this.labelTimers.TabIndex = 11;
            this.labelTimers.Tag = "PreLogin";
            this.labelTimers.Text = "Time for each player";
            // 
            // FormChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1251, 631);
            this.Controls.Add(this.labelTimers);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.checkBoxTimers);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelSecondNickname);
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
            this.Text = "Chess Game";
            this.Load += new System.EventHandler(this.FormChess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
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
        private System.Windows.Forms.Label labelSecondNickname;
        private System.Windows.Forms.TextBox textBoxPlayer2Nickname;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.CheckBox checkBoxTimers;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.Label labelTimers;
    }
}