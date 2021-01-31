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

        bool Player1Turn = true;
        bool GameStarted = false;
        bool PawnClicked = false;
        Pawn PawnSelected;
        int time_PLAYER1;
        int time_PLAYER2;
        int current_countdown;

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

            //then initialize all pawns in the board.
            Pawn BlackRook1   = new Pawn("Rook", false, pictureBoxBlackRook1);
            Pawn BlackKnight1 = new Pawn("Knight", false, pictureBoxBlackKnight1);
            Pawn BlackBishop1 = new Pawn("Bishop", false, pictureBoxBlackBishop1);
            Pawn BlackBishop2 = new Pawn("Bishop", false, pictureBoxBlackBishop2);
            Pawn BlackKnight2 = new Pawn("Knight", false, pictureBoxBlackKnight2);
            Pawn BlackRook2   = new Pawn("Rook", false, pictureBoxBlackRook2);
            Pawn BlackQueen   = new Pawn("Queen", false, pictureBoxBlackQueen);
            Pawn BlackKing    = new Pawn("King", false, pictureBoxBlackKing);
            Pawn BlackPawn1   = new Pawn("Pawn", false, pictureBoxBlackPawn1);
            Pawn BlackPawn2   = new Pawn("Pawn", false, pictureBoxBlackPawn2);
            Pawn BlackPawn3   = new Pawn("Pawn", false, pictureBoxBlackPawn3);
            Pawn BlackPawn4   = new Pawn("Pawn", false, pictureBoxBlackPawn4);
            Pawn BlackPawn5   = new Pawn("Pawn", false, pictureBoxBlackPawn5);
            Pawn BlackPawn6   = new Pawn("Pawn", false, pictureBoxBlackPawn6);
            Pawn BlackPawn7   = new Pawn("Pawn", false, pictureBoxBlackPawn7);
            Pawn BlackPawn8   = new Pawn("Pawn", false, pictureBoxBlackPawn8);

            Pawn WhiteRook1   = new Pawn("Rook", true, pictureBoxWhiteRook1);
            Pawn WhiteKnight1 = new Pawn("Knight", true, pictureBoxWhiteKnight1);
            Pawn WhiteBishop1 = new Pawn("Bishop", true, pictureBoxWhiteBishop1);
            Pawn WhiteBishop2 = new Pawn("Bishop", true, pictureBoxWhiteBishop2);
            Pawn WhiteKnight2 = new Pawn("Knight", true, pictureBoxWhiteKnight2);
            Pawn WhiteRook2   = new Pawn("Rook", true, pictureBoxWhiteRook2);
            Pawn WhiteQueen   = new Pawn("Queen", true, pictureBoxWhiteQueen);
            Pawn WhiteKing    = new Pawn("King", true, pictureBoxWhiteKing);
            Pawn WhitePawn1   = new Pawn("Pawn", true, pictureBoxWhitePawn1);
            Pawn WhitePawn2   = new Pawn("Pawn", true, pictureBoxWhitePawn2);
            Pawn WhitePawn3   = new Pawn("Pawn", true, pictureBoxWhitePawn3);
            Pawn WhitePawn4   = new Pawn("Pawn", true, pictureBoxWhitePawn4);
            Pawn WhitePawn5   = new Pawn("Pawn", true, pictureBoxWhitePawn5);
            Pawn WhitePawn6   = new Pawn("Pawn", true, pictureBoxWhitePawn6);
            Pawn WhitePawn7   = new Pawn("Pawn", true, pictureBoxWhitePawn7);
            Pawn WhitePawn8   = new Pawn("Pawn", true, pictureBoxWhitePawn8);

            Chessboard.InitializeVariables();

            BlackRook1.SetLocation(0, 0);
            BlackKnight1.SetLocation(1, 0);
            BlackBishop1.SetLocation(2, 0);
            BlackQueen.SetLocation(3, 0);
            BlackKing.SetLocation(4, 0);
            BlackBishop2.SetLocation(5, 0);
            BlackKnight2.SetLocation(6, 0);
            BlackRook2.SetLocation(7, 0);
            BlackPawn1.SetLocation(0, 1);
            BlackPawn2.SetLocation(1, 1);
            BlackPawn3.SetLocation(2, 1);
            BlackPawn4.SetLocation(3, 1);
            BlackPawn5.SetLocation(4, 1);
            BlackPawn6.SetLocation(5, 1);
            BlackPawn7.SetLocation(6, 1);
            BlackPawn8.SetLocation(7, 1);

            WhiteRook1.SetLocation(0, 7);
            WhiteKnight1.SetLocation(1, 7);
            WhiteBishop1.SetLocation(2, 7);
            WhiteQueen.SetLocation(3, 7);
            WhiteKing.SetLocation(4, 7);
            WhiteBishop2.SetLocation(5, 7);
            WhiteKnight2.SetLocation(6, 7);
            WhiteRook2.SetLocation(7, 7);
            WhitePawn1.SetLocation(0, 6);
            WhitePawn2.SetLocation(1, 6);
            WhitePawn3.SetLocation(2, 6);
            WhitePawn4.SetLocation(3, 6);
            WhitePawn5.SetLocation(4, 6);
            WhitePawn6.SetLocation(5, 6);
            WhitePawn7.SetLocation(6, 6);
            WhitePawn8.SetLocation(7, 6);
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
            Player1Turn = !Player1Turn;
        }

        private void AnyPawnClicked(object sender, MouseEventArgs e)
        {
            PictureBox pressed = (PictureBox)sender;

            Pawn PawnPressed = (from pawn in Chessboard.ActivePawns where pawn.Texture.Equals(pressed) select pawn).ToArray()[0];

            PawnSelected = (PawnSelected == null) ? PawnPressed : PawnSelected;

            //if no pawns are selected the pawn pressed is the same as the players turn...
            if (!PawnClicked && PawnPressed.IsWhite == Player1Turn)
            {
                PawnClicked = true;
                PawnPressed.Texture.BackColor = Color.Green;
                PawnSelected = PawnPressed;
                Console.WriteLine(PawnPressed.Name);
            }
            //if the pawn selected is about to "eat" another pawn of a different colour
            else if (PawnPressed.IsWhite != PawnSelected.IsWhite)
            {
                PawnSelected.DisposePawn(PawnPressed);
                PawnSelected.Texture.BackColor = Color.Transparent;
                PawnClicked = false;

                Player1Turn = !Player1Turn;
                PawnSelected = null;
            }
            //if the player selects two pawns of the same colour.
            else
            {
                PawnSelected.Texture.BackColor = Color.Transparent;
                PawnClicked = false;
                PawnSelected = null;
            }
        }
    }
}
