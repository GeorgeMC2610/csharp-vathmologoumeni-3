
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
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.labelSecondNickname = new System.Windows.Forms.Label();
            this.textBoxPlayer2Nickname = new System.Windows.Forms.TextBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.checkBoxTimers = new System.Windows.Forms.CheckBox();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.labelTimers = new System.Windows.Forms.Label();
            this.panelChessBoard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Font = new System.Drawing.Font("Helvetica Rounded", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1239, 27);
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
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBoxPlayer1Nickname
            // 
            this.textBoxPlayer1Nickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPlayer1Nickname.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer1Nickname.Location = new System.Drawing.Point(6, 190);
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
            this.labelFirstNickname.Location = new System.Drawing.Point(0, 168);
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
            this.labelTitle.Location = new System.Drawing.Point(0, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(519, 32);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Tag = "PreLogin";
            this.labelTitle.Text = "Welcome! Ready to play some Chess?";
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtitle.Location = new System.Drawing.Point(3, 73);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(422, 28);
            this.labelSubtitle.TabIndex = 5;
            this.labelSubtitle.Tag = "PreLogin";
            this.labelSubtitle.Text = "Type your nicknames in order to begin!";
            // 
            // labelSecondNickname
            // 
            this.labelSecondNickname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSecondNickname.AutoSize = true;
            this.labelSecondNickname.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondNickname.Location = new System.Drawing.Point(5, 280);
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
            this.textBoxPlayer2Nickname.Location = new System.Drawing.Point(6, 302);
            this.textBoxPlayer2Nickname.MaxLength = 45;
            this.textBoxPlayer2Nickname.Name = "textBoxPlayer2Nickname";
            this.textBoxPlayer2Nickname.Size = new System.Drawing.Size(282, 30);
            this.textBoxPlayer2Nickname.TabIndex = 6;
            this.textBoxPlayer2Nickname.Tag = "PreLogin";
            this.textBoxPlayer2Nickname.TextChanged += new System.EventHandler(this.PreLoginControls_Changed);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStartGame.BackColor = System.Drawing.Color.Green;
            this.buttonStartGame.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartGame.ForeColor = System.Drawing.Color.White;
            this.buttonStartGame.Location = new System.Drawing.Point(0, 796);
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
            this.checkBoxTimers.Location = new System.Drawing.Point(16, 195);
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
            this.numericUpDownMinutes.Location = new System.Drawing.Point(10, 305);
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
            this.labelTimers.Location = new System.Drawing.Point(7, 283);
            this.labelTimers.Name = "labelTimers";
            this.labelTimers.Size = new System.Drawing.Size(262, 19);
            this.labelTimers.TabIndex = 11;
            this.labelTimers.Tag = "PreLogin";
            this.labelTimers.Text = "Time for each player (in minutes)";
            // 
            // panelChessBoard
            // 
            this.panelChessBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChessBoard.BackgroundImage = global::csharp_vathmologoumeni_3.Properties.Resources.chess_board;
            this.panelChessBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelChessBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelChessBoard.Location = new System.Drawing.Point(294, 27);
            this.panelChessBoard.Name = "panelChessBoard";
            this.panelChessBoard.Size = new System.Drawing.Size(780, 780);
            this.panelChessBoard.TabIndex = 12;
            // 
            // FormChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.panelChessBoard);
            this.Controls.Add(this.labelTimers);
            this.Controls.Add(this.numericUpDownMinutes);
            this.Controls.Add(this.checkBoxTimers);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelSecondNickname);
            this.Controls.Add(this.textBoxPlayer2Nickname);
            this.Controls.Add(this.labelSubtitle);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Label labelSecondNickname;
        private System.Windows.Forms.TextBox textBoxPlayer2Nickname;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.CheckBox checkBoxTimers;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.Label labelTimers;
        private System.Windows.Forms.Panel panelChessBoard;
    }
}