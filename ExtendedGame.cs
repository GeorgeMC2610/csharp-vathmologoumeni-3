using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_3
{
    public static class ExtendedGame
    {
        public static void makeBackgrounds(Panel panelChessBoard, FormChess.panelpress PanelPress)
        {
            foreach (Point p in Chessboard.ValidPoints)
            {
                PictureBox pb = new PictureBox();
                pb.Visible = false;
                pb.Location = p;
                pb.Width = pb.Height = 95;
                pb.BackColor = Color.PaleTurquoise;
                pb.SizeMode = PictureBoxSizeMode.Normal;
                pb.Cursor = Cursors.Hand;
                pb.MouseClick += new MouseEventHandler(PanelPress);

                panelChessBoard.Controls.Add(pb);
            }
        }

        public static bool showOrhidePictureBoxat(Point p, bool show, bool p1turn, Panel panelChessBoard) //returns true if a pawn background color changes. Returns false if an empty square is colored 
        {
            bool returnval = true;

            foreach (var pb in panelChessBoard.Controls.OfType<PictureBox>())
            {
                if (pb.Location == p && pb.Name.Equals(""))
                {
                    pb.Visible = show;
                    returnval = false;
                    break;
                }
                else if (pb.Location == p)
                {
                    pb.BackColor = show && (p1turn && pb.Name.Contains("Black") || !p1turn && pb.Name.Contains("White")) ? Color.PaleTurquoise : Color.Transparent;
                    returnval = true;
                    break;
                }
            }

            return returnval;
        }

        public static void hideAll(bool p1turn, Panel panelChessBoard)
        {
            foreach (var pb in panelChessBoard.Controls.OfType<PictureBox>())
                showOrhidePictureBoxat(pb.Location, false, p1turn, panelChessBoard);
        }

        public static void showValidmoves(bool p1turn, bool firstturn, Panel panelChessBoard, PictureBox pressed)
        {
            if (pressed.Name.Contains("Rook"))
            {
                Point pxr, pyd, pxl, pyu;
                pxr = pyd = pxl = pyu = new Point(pressed.Location.X, pressed.Location.Y);
                
                bool pawnxr, pawnyd, pawnxl, pawnyu;
                pawnxr = pawnyd = pawnxl = pawnyu = false;

                int i = 1;

                while (pxr.X != 672 && !pawnxr || pyd.Y != 672 && !pawnyd || pxl.X != 14 && !pawnxl || pyu.Y != 14 && !pawnyu)
                {
                    if (pxr.X != 672 && !pawnxr)
                        pxr = new Point(pressed.Location.X + 94 * i, pressed.Location.Y);

                    if (pyd.Y != 672 && !pawnyd)
                        pyd = new Point(pressed.Location.X, pressed.Location.Y + 94 * i);

                    if (pxl.X != 14 && !pawnxl)
                        pxl = new Point(pressed.Location.X - 94 * i, pressed.Location.Y);

                    if (pyu.Y != 14 && !pawnyu)
                        pyu = new Point(pressed.Location.X, pressed.Location.Y - 94 * i);

                    pawnxr = ExtendedGame.showOrhidePictureBoxat(pxr, true, p1turn, panelChessBoard);
                    pawnyd = ExtendedGame.showOrhidePictureBoxat(pyd, true, p1turn, panelChessBoard);
                    pawnxl = ExtendedGame.showOrhidePictureBoxat(pxl, true, p1turn, panelChessBoard);
                    pawnyu = ExtendedGame.showOrhidePictureBoxat(pyu, true, p1turn, panelChessBoard);

                    i++;
                }
            }
            else if (pressed.Name.Contains("Knight"))
            {
                Point pur, pul, pdr, pdl;

                pur = new Point(pressed.Location.X + 94, pressed.Location.Y - 94 * 2);
                pul = new Point(pressed.Location.X - 94, pressed.Location.Y - 94 * 2);
                pdr = new Point(pressed.Location.X + 94, pressed.Location.Y + 94 * 2);
                pdl = new Point(pressed.Location.X - 94, pressed.Location.Y + 94 * 2);

                ExtendedGame.showOrhidePictureBoxat(pur, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pul, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pdr, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pdl, true, p1turn, panelChessBoard);
            }
            else if (pressed.Name.Contains("Bishop"))
            {
                Point pur, pul, pdr, pdl;
                pur = pul = pdr = pdl = new Point(pressed.Location.X, pressed.Location.Y);

                bool pawnur, pawnul, pawndr, pawndl;
                pawnur = pawnul = pawndr = pawndl = false;

                int i = 1;

                while (pur.X != 672 && pur.Y != 14 && !pawnur || pul.X != 14 && pul.Y != 14 && !pawnul || pdr.X != 672 && pdr.Y != 672 && !pawndr || pdl.X != 14 && pdl.Y != 672 && !pawndl)
                {
                    if (pur.X != 672 && pur.Y != 14 && !pawnur)
                        pur = new Point(pressed.Location.X + 94 * i, pressed.Location.Y - 94 * i);

                    if (pul.X != 14 && pul.Y != 14 && !pawnul)
                        pul = new Point(pressed.Location.X - 94 * i, pressed.Location.Y - 94 * i);

                    if (pdr.X != 672 && pdr.Y != 672 && !pawndr)
                        pdr = new Point(pressed.Location.X + 94 * i, pressed.Location.Y + 94 * i);

                    if (pdl.X != 14 && pdl.Y != 672 && !pawndl)
                        pdl = new Point(pressed.Location.X - 94 * i, pressed.Location.Y + 94 * i);

                    pawnur = ExtendedGame.showOrhidePictureBoxat(pur, true, p1turn, panelChessBoard);
                    pawnul = ExtendedGame.showOrhidePictureBoxat(pul, true, p1turn, panelChessBoard);
                    pawndr = ExtendedGame.showOrhidePictureBoxat(pdr, true, p1turn, panelChessBoard);
                    pawndl = ExtendedGame.showOrhidePictureBoxat(pdl, true, p1turn, panelChessBoard);

                    i++;
                }
            }
            else if (pressed.Name.Contains("Queen"))
            {
                String original_name = pressed.Name;

                pressed.Name = "Rook";
                showValidmoves(p1turn, firstturn, panelChessBoard, pressed);

                pressed.Name = "Bishop";
                showValidmoves(p1turn, firstturn, panelChessBoard, pressed);

                pressed.Name = original_name;
            }
            else if (pressed.Name.Contains("King"))
            {
                Point pur, pul, pdr, pdl, pl, pr, pd, pu;

                pur = new Point(pressed.Location.X + 94, pressed.Location.Y - 94);
                pul = new Point(pressed.Location.X - 94, pressed.Location.Y - 94);
                pdr = new Point(pressed.Location.X + 94, pressed.Location.Y + 94);
                pdl = new Point(pressed.Location.X - 94, pressed.Location.Y + 94);
                pl  = new Point(pressed.Location.X - 94, pressed.Location.Y);
                pr  = new Point(pressed.Location.X + 94, pressed.Location.Y);
                pd  = new Point(pressed.Location.X, pressed.Location.Y + 94);
                pu  = new Point(pressed.Location.X, pressed.Location.Y - 94);

                ExtendedGame.showOrhidePictureBoxat(pur, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pul, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pdr, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pdl, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pl, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pr, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pd, true, p1turn, panelChessBoard);
                ExtendedGame.showOrhidePictureBoxat(pu, true, p1turn, panelChessBoard);
            }
            else
            {
                Point forward, diagl, diagr;

                forward = p1turn ? new Point(pressed.Location.X, pressed.Location.Y - 94) : new Point(pressed.Location.X, pressed.Location.Y + 94);
                diagl = p1turn ? new Point(pressed.Location.X - 94, pressed.Location.Y - 94) : new Point(pressed.Location.X - 94, pressed.Location.Y + 94);
                diagr = p1turn ? new Point(pressed.Location.X + 94, pressed.Location.Y - 94) : new Point(pressed.Location.X + 94, pressed.Location.Y + 94);

                Pawn[] forwardpawn = (from pawn in Chessboard.ActivePawns where pawn.Location.Equals(forward) select pawn).ToArray();
                if (forwardpawn.Length == 0)
                    ExtendedGame.showOrhidePictureBoxat(forward, true, p1turn, panelChessBoard);
                                
                Pawn[] diaglpawn = (from pawn in Chessboard.ActivePawns where pawn.Location.Equals(diagl) select pawn).ToArray();
                if (diaglpawn.Length != 0)
                    ExtendedGame.showOrhidePictureBoxat(diagl, true, p1turn, panelChessBoard);

                Pawn[] diagrpawn = (from pawn in Chessboard.ActivePawns where pawn.Location.Equals(diagr) select pawn).ToArray();
                if (diagrpawn.Length != 0)
                    ExtendedGame.showOrhidePictureBoxat(diagr, true, p1turn, panelChessBoard);

                if (firstturn)
                {
                    forward.Y -= 94;
                    ExtendedGame.showOrhidePictureBoxat(forward, true, p1turn, panelChessBoard);
                }
            }
        }
    }
}
