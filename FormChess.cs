﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        public delegate void panelpress(object sender, MouseEventArgs e);
        private static bool firstturn;
        private static bool exit;

        bool Player1Turn = true;
        bool GameStarted = false;
        bool PawnClicked = false;
        Pawn PawnSelected;
        int time_PLAYER1;
        int time_PLAYER2;

        private void AnyButtonClicked(object sender, EventArgs e)
        {
            //all buttons call this function, to reduce nesting and function writing.
            Control pressed = (Control)sender;

            switch (pressed.Name)
            {
                //when the player exits, show the form that was already shown before. NOTE: There will be a popup message if the game has started.
                case "buttonExit":
                    DialogResult coninueGame = (GameStarted) ? MessageBox.Show("All progress will be discarded. Are you sure you want to exit?", "Exit Chess", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) : DialogResult.OK;

                    if (coninueGame == DialogResult.Cancel)
                        return;

                    Close();
                    break;
                //when the player restarts the game, we show a dialog. If the game hasn't started, the game doesn't show the dialog and immideately restarts the game.
                case "buttonStartOver":
                    DialogResult continueGame = (GameStarted) ? MessageBox.Show("Are you sure you want to restart the game?", "Restart Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) : DialogResult.OK;
                    if (continueGame == DialogResult.Cancel)
                        return;

                    exit = false;
                    Close();
                    new FormChess().Show();
                    break;
                //when the player starts the game, enable everything.
                case "buttonStartGame":
                    GameStarted = true;
                    EnableGame();
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
            firstturn = true;
            exit = true;

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
            
            labelPlayer1Timer.Visible = labelPlayer2Timer.Visible = panelChessBoard.Visible = false;
            buttonStartOver.Enabled = false;

            Chessboard.ActivePawns.Clear();

            //then initialize all pawns in the board.
            Pawn BlackRook1   = new Pawn("Rook",   false, pictureBoxBlackRook1);
            Pawn BlackKnight1 = new Pawn("Knight", false, pictureBoxBlackKnight1);
            Pawn BlackBishop1 = new Pawn("Bishop", false, pictureBoxBlackBishop1);
            Pawn BlackBishop2 = new Pawn("Bishop", false, pictureBoxBlackBishop2);
            Pawn BlackKnight2 = new Pawn("Knight", false, pictureBoxBlackKnight2);
            Pawn BlackRook2   = new Pawn("Rook",   false, pictureBoxBlackRook2);
            Pawn BlackQueen   = new Pawn("Queen",  false, pictureBoxBlackQueen);
            Pawn BlackKing    = new Pawn("King",   false, pictureBoxBlackKing);
            Pawn BlackPawn1   = new Pawn("Pawn",   false, pictureBoxBlackPawn1);
            Pawn BlackPawn2   = new Pawn("Pawn",   false, pictureBoxBlackPawn2);
            Pawn BlackPawn3   = new Pawn("Pawn",   false, pictureBoxBlackPawn3);
            Pawn BlackPawn4   = new Pawn("Pawn",   false, pictureBoxBlackPawn4);
            Pawn BlackPawn5   = new Pawn("Pawn",   false, pictureBoxBlackPawn5);
            Pawn BlackPawn6   = new Pawn("Pawn",   false, pictureBoxBlackPawn6);
            Pawn BlackPawn7   = new Pawn("Pawn",   false, pictureBoxBlackPawn7);
            Pawn BlackPawn8   = new Pawn("Pawn",   false, pictureBoxBlackPawn8);

            Pawn WhiteRook1   = new Pawn("Rook",   true, pictureBoxWhiteRook1);
            Pawn WhiteKnight1 = new Pawn("Knight", true, pictureBoxWhiteKnight1);
            Pawn WhiteBishop1 = new Pawn("Bishop", true, pictureBoxWhiteBishop1);
            Pawn WhiteBishop2 = new Pawn("Bishop", true, pictureBoxWhiteBishop2);
            Pawn WhiteKnight2 = new Pawn("Knight", true, pictureBoxWhiteKnight2);
            Pawn WhiteRook2   = new Pawn("Rook",   true, pictureBoxWhiteRook2);
            Pawn WhiteQueen   = new Pawn("Queen",  true, pictureBoxWhiteQueen);
            Pawn WhiteKing    = new Pawn("King",   true, pictureBoxWhiteKing);
            Pawn WhitePawn1   = new Pawn("Pawn",   true, pictureBoxWhitePawn1);
            Pawn WhitePawn2   = new Pawn("Pawn",   true, pictureBoxWhitePawn2);
            Pawn WhitePawn3   = new Pawn("Pawn",   true, pictureBoxWhitePawn3);
            Pawn WhitePawn4   = new Pawn("Pawn",   true, pictureBoxWhitePawn4);
            Pawn WhitePawn5   = new Pawn("Pawn",   true, pictureBoxWhitePawn5);
            Pawn WhitePawn6   = new Pawn("Pawn",   true, pictureBoxWhitePawn6);
            Pawn WhitePawn7   = new Pawn("Pawn",   true, pictureBoxWhitePawn7);
            Pawn WhitePawn8   = new Pawn("Pawn",   true, pictureBoxWhitePawn8);

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

            panelpress panpress = PanelPress;

            ExtendedGame.makeBackgrounds(panelChessBoard,panpress);
        }

        private void EnableOrDisablePlayButton(bool handling)
        {
            //set the button's color to be grey if it's disabled, or green if it's enabled.
            Color backColor = (handling) ? Color.Green : Color.Gray;
            Color foreColor = (handling) ? Color.White : Color.Black;

            buttonStartGame.Enabled   = handling;
            buttonStartGame.ForeColor = foreColor;
            buttonStartGame.BackColor = backColor;
        }

        private void EnableGame()
        {
            //make all pre-login controls invisible
            foreach (Control c in Controls)
                if (c.Tag != null && c.Tag.ToString().Equals("PreLogin"))
                    c.Visible = false;
                else
                    c.Visible = true;

            labelTurn.Text          = "It's " + textBoxPlayer1Nickname.Text + "'s (White Pawns) turn.";
            labelTurn.Location      = new Point(panelChessBoard.Location.X + panelChessBoard.Width / 2 - labelTurn.Width / 2, labelTurn.Location.Y);
            buttonStartOver.Enabled = true;

            //set the minutes
            if (numericUpDownMinutes.Enabled)
            {
                time_PLAYER1 = 60 * (int)numericUpDownMinutes.Value;
                time_PLAYER2 = 60 * (int)numericUpDownMinutes.Value;

                timerCountdown.Enabled = true;
            }
        }

        private void EndGame(string winner)
        {
            //we set the labels that announce the game winning to be visible
            labelWinner.Visible = labelGameOver.Visible = true;
            labelWinner.Text = winner + " won!";

            //we set their location properly
            labelGameOver.Location = new Point(panelChessBoard.Size.Width / 2 - labelGameOver.Size.Width / 2, labelGameOver.Location.Y);
            labelWinner.Location   = new Point(panelChessBoard.Size.Width / 2 - labelWinner.Size.Width / 2, labelWinner.Location.Y);

            //and then we set every pawn to be disabled so the controls don't keep tracking.
            Chessboard.ActivePawns.ForEach(p => p.Texture.Enabled = false);
            timerCountdown.Enabled = false;
            GameStarted = false;
            InsertToDatabase(winner);
        }

        private void InsertToDatabase(string winner)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;;Data Source=ChessGames.mdb");
                connection.Open();

                OleDbCommand command = new OleDbCommand("INSERT INTO Games (Player1, Player2, Winner, Timer, DateEnded, TimeEnded) VALUES ('" + textBoxPlayer1Nickname.Text + "', '"
                                                                                                                                              + textBoxPlayer2Nickname.Text + "', '"
                                                                                                                                              + winner + "', '"
                                                                                                                                              + (checkBoxTimers.Checked ? numericUpDownMinutes.Value.ToString() + " minutes" : "None") + "', '"
                                                                                                                                              + DateTime.Now.ToShortDateString() + "', '"
                                                                                                                                              + DateTime.Now.ToLongTimeString() + "')", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured while trying to write the game in the database. This game will not be recorded.\n\nERROR MESSAGE: " + e.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InverseTurns()
        {
            //to inverse the turns, we set the opposite bool to be the turn.
            Player1Turn   = !Player1Turn;

            //and then we update the label which shows the players' turn.
            labelTurn.Text = "It's " + (Player1Turn ? textBoxPlayer1Nickname.Text + "'s (White Pawns)" : textBoxPlayer2Nickname.Text + "'s (Black Pawns)") + " turn.";
            labelTurn.Location = new Point(panelChessBoard.Location.X + panelChessBoard.Width / 2 - labelTurn.Width / 2, labelTurn.Location.Y);
        }

        private void PanelPress(object sender, MouseEventArgs e)
        {
            //if (!PawnClicked)
            //    return;

            //when any player presses a blue picturebox in the panel with a selected pawn, move that pawn to the selected location.

            //PawnSelected.SetLocation(Chessboard.GetLocationByClick(((PictureBox)sender).Location));
            PawnSelected.SetLocation(((PictureBox)sender).Location);

            PawnSelected.Texture.BackColor = Color.Transparent;
            PawnClicked = false;

            ExtendedGame.hideAll(Player1Turn,panelChessBoard);
            firstturn = false;

            InverseTurns();
        }

        //All pawns call this function. The program understands by itself which pawn it is.
        private void AnyPawnClicked(object sender, MouseEventArgs e)
        {
            PictureBox pressed = (PictureBox)sender;

            Pawn PawnPressed = (from pawn in Chessboard.ActivePawns where pawn.Texture.Equals(pressed) select pawn).ToArray()[0];
            PawnSelected = (PawnSelected == null) ? PawnPressed : PawnSelected;

            //if no pawns are selected the pawn pressed is the same as the players turn...
            if (!PawnClicked && PawnPressed.IsWhite == Player1Turn)
            {
                ExtendedGame.showValidmoves(Player1Turn, firstturn, panelChessBoard, pressed);

                //select the pawn
                PawnClicked = true;
                PawnPressed.Texture.BackColor = Color.Green;
                PawnSelected = PawnPressed;
            }
            //if the pawn selected is about to "eat" another pawn of a different colour
            else if (PawnPressed.IsWhite != PawnSelected.IsWhite && PawnPressed.Texture.BackColor == Color.PaleTurquoise)
            {
                //Dispose the pawn that was selected.
                PawnSelected.DisposePawn(PawnPressed);

                ExtendedGame.hideAll(Player1Turn, panelChessBoard);

                //Deselect the pawn
                PawnSelected.Texture.BackColor = Color.Transparent;
                PawnClicked = false;

                //Inverse the turn.
                InverseTurns();
                PawnSelected = null;

                //If the disposed pawn was a king, end the game
                if (PawnPressed.Name.Equals("King"))
                    EndGame((PawnPressed.IsWhite) ? textBoxPlayer2Nickname.Text : textBoxPlayer1Nickname.Text); //determine the winner by the colour of the king slayed.
            }
            //if the player selects two pawns of the same colour.
            else
            {
                ExtendedGame.hideAll(Player1Turn, panelChessBoard);

                //just deselect the pawn.
                PawnSelected.Texture.BackColor = Color.Transparent;
                PawnClicked = false;
                PawnSelected = null;
            }
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            //according to the player's turn, decrement their time.
            time_PLAYER1 = (Player1Turn) ? time_PLAYER1 - 1 : time_PLAYER1;
            time_PLAYER2 = (Player1Turn) ? time_PLAYER2 : time_PLAYER2 - 1;

            //update the labels showing the time
            labelPlayer1Timer.Text = textBoxPlayer1Nickname.Text + "'s Time:" + Environment.NewLine + TimeSpan.FromSeconds(time_PLAYER1);
            labelPlayer2Timer.Text = textBoxPlayer2Nickname.Text + "'s Time:" + Environment.NewLine + TimeSpan.FromSeconds(time_PLAYER2);

            //update their location to be proper as well.
            labelPlayer1Timer.Location = new Point(panelChessBoard.Size.Width + panelChessBoard.Location.X + 12, labelPlayer1Timer.Location.Y);
            labelPlayer2Timer.Location = new Point(panelChessBoard.Location.X - labelPlayer2Timer.Size.Width - 12, labelPlayer2Timer.Location.Y);

            //and if the time runs out, end the game.
            if (time_PLAYER1 == 0 || time_PLAYER2 == 0)
                EndGame((time_PLAYER1 == 0)? textBoxPlayer2Nickname.Text : textBoxPlayer1Nickname.Text);
        }

        private void AnyToolStripItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem ItemClicked = (ToolStripMenuItem)sender;

            string message;
            switch (ItemClicked.Name)
            {
                case "manageDatabaseToolStripMenuItem":
                    new FormChessDB().Show();
                    Hide();
                    break;

                case "howToPlayToolStripMenuItem":
                    message = "SELECTING A PAWN: In order to select an allied pawn, it must be your turn. The turn is determined each time a player makes a move. Clicking" +
                                     " on any allied pawn, will make its background green, letting you know it's selected.\n\n" +

                                     "MOVING A PAWN: Clicking at any point of the chessboard, that isn't an allied pawn, will make the selected pawn to move to the clicked point." +
                                     " Once that's done, the turn will change.\n\n" +
                                     
                                     "DISPOSING ENEMY PAWNS: While having selected an allied pawn, you will be able to click at an enemy pawn to dispose it. All disposed pawns" +
                                     " disappear and become anavailable for the rest of the game.";

                    MessageBox.Show(message, "How To Play The Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "winningTheGameToolStripMenuItem":
                    message = "There is no Checkmate or automated rules. Therefore leaving two possibilities to win the game:\n\n" +

                              "- The game will end if the time of any player runs out. In this occasion, the player that ran out of time loses.\n\n" +
                              
                              "- At any point, any player can dispose the enemy King. If a player loses their King, they lose.";

                    MessageBox.Show(message, "Winning The Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "rulesToolStripMenuItem":
                    message = "By clicking yes, you will be redirected to a Wikipedia Page, showing the rules of Chess. Do you want to?";

                    if (MessageBox.Show(message, "Chess Rules", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                        return;

                    try
                    {
                        System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Rules_of_chess");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong. EXCEPTION MESSAGE: " + ex.Message, "Error");
                    }

                    break;
            }
        }

        private void FormChess_FormClosed(object sender, FormClosedEventArgs e)
        {
            //show the first form that has appeared (the main menu).
            if (exit)
                Application.OpenForms[0].Show();
        }
    }
}