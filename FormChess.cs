﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_3
{
    public partial class FormChess : Form
    {
        public FormChess()
        {
            InitializeComponent();
        }

        bool GameStarted = false;
        bool PawnClicked = false;
        Pawn PawnSelected;

        private void AnyButtonClicked(object sender, EventArgs e)
        {
            Control pressed = (Control)sender;

            switch (pressed.Name)
            {
                //when the player exits, show the form that was already shown before. NOTE: There will be a popup message if the game has started.
                case "buttonExit":
                    DialogResult coninueGame = (GameStarted) ? MessageBox.Show("All progress will be discarded. Are you sure you want to exit?", "Exit Chess", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) : DialogResult.OK;

                    if (coninueGame == DialogResult.Cancel)
                        return;

                    Application.OpenForms[0].Show();
                    Close();
                    break;

                case "buttonStartGame":
                    GameStarted = true;
                    EnableOrDisableGame(!GameStarted);
                    break;

                case "panelChessBoard":
                    MouseEventArgs mouse = (MouseEventArgs)e;
                    Console.WriteLine(mouse.X.ToString() + ", " + mouse.Y.ToString());

                    break;
            }
        }

        //we merge all the pre-login controls to call the same function to save space.
        private void PreLoginControls_Changed(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            switch (control.GetType().Name)
            {
                //if the control that was changed is a text box, then see if the play button can be enabled, by seeing if any of the textboxes are empty.
                case "TextBox":
                    EnableOrDisablePlayButton(!textBoxPlayer1Nickname.Text.Equals("") && !textBoxPlayer2Nickname.Text.Equals(""));
                    break;
                //if it was a check box, it will lock or unlock the numericupdown accoordingly.
                case "CheckBox":
                    numericUpDownMinutes.Enabled = checkBoxTimers.Checked;
                    break;
            }
        }

        private void FormChess_Load(object sender, EventArgs e)
        {
            //as soon as the form loads, disable the play button.
            EnableOrDisablePlayButton(false);
            checkBoxTimers.CheckState = CheckState.Checked;

            //and then set the pre-login controls to be at their proper location
            labelTitle.Location             = new Point(Width / 2 - labelTitle.Width / 2, labelTitle.Location.Y);
            labelSubtitle.Location          = new Point(Width / 2 - labelSubtitle.Width / 2, labelSubtitle.Location.Y);
            buttonStartGame.Location        = new Point(Width / 2 - buttonStartGame.Width / 2, buttonStartGame.Location.Y);

            textBoxPlayer1Nickname.Location = new Point(buttonStartGame.Location.X, textBoxPlayer1Nickname.Location.Y);
            textBoxPlayer2Nickname.Location = new Point(buttonStartGame.Location.X, textBoxPlayer2Nickname.Location.Y);
            labelFirstNickname.Location     = new Point(textBoxPlayer1Nickname.Location.X, labelFirstNickname.Location.Y);
            labelSecondNickname.Location    = new Point(textBoxPlayer2Nickname.Location.X, labelSecondNickname.Location.Y);

            checkBoxTimers.Location         = new Point(buttonStartGame.Location.X + buttonStartGame.Size.Width - checkBoxTimers.Size.Width, checkBoxTimers.Location.Y);
            labelTimers.Location            = new Point(checkBoxTimers.Location.X, labelTimers.Location.Y);
            numericUpDownMinutes.Location   = new Point(checkBoxTimers.Location.X, numericUpDownMinutes.Location.Y);

            panelChessBoard.Location        = new Point(Width / 2 - panelChessBoard.Width / 2, Height / 2 - panelChessBoard.Height / 2);
            panelChessBoard.Visible = false;

            Pawn BlackRook1   = new Pawn("Rook", false, pictureBoxBlackRook1);
            Pawn BlackKnight1 = new Pawn("Knight", false, pictureBoxBlackKnight1);
            Pawn WhiteKnight1 = new Pawn("Knight", true, pictureBoxWhiteKnight1);

            Chessboard.InitializeVariables();

            BlackRook1.SetLocation(0, 0);
            BlackKnight1.SetLocation(1, 0);

            WhiteKnight1.SetLocation(1, 7);

            Console.WriteLine(BlackRook1.Location);
            Console.WriteLine(BlackKnight1.Location);
        }

        private void EnableOrDisablePlayButton(bool handling)
        {
            Color backColor = (handling) ? Color.Green : Color.Gray;
            Color foreColor = (handling) ? Color.White : Color.Black;

            buttonStartGame.Enabled   = handling;
            buttonStartGame.ForeColor = foreColor;
            buttonStartGame.BackColor = backColor;
        }

        private void EnableOrDisableGame(bool handling)
        {
            foreach (Control c in Controls)
                if (c.Tag != null)
                    c.Visible = handling;
                else
                    c.Visible = !handling;
                    

            if (handling)
            {

            }
            else
            {
                
            }
        }

        private void PanelPress(object sender, MouseEventArgs e)
        {
            if (!PawnClicked)
                return;

            PawnSelected.SetLocation(Chessboard.GetLocationByClick(e.Location));
            PawnSelected.Texture.BackColor = Color.Transparent;
            PawnClicked = false;
        }

        private void AnyPawnClicked(object sender, MouseEventArgs e)
        {
            PictureBox pressed = (PictureBox)sender;

            Pawn PawnPressed = (from pawn in Chessboard.ActivePawns where pawn.Texture.Equals(pressed) select pawn).ToArray()[0];

            if (!PawnClicked)
            {
                PawnClicked = true;
                PawnPressed.Texture.BackColor = Color.Green;
                PawnSelected = PawnPressed;
                Console.WriteLine(PawnPressed.Name);
            }
            else if (PawnPressed.IsWhite != PawnSelected.IsWhite)
            {
                PawnSelected.DisposePawn(PawnPressed);
                PawnSelected.Texture.BackColor = Color.Transparent;
                PawnClicked = false;
            }
            else
            {
                PawnSelected.Texture.BackColor = Color.Transparent;
                PawnClicked = false;
            }
        }
    }
}
