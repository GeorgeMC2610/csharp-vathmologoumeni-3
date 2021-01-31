using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_3
{
    class Pawn
    {
        public PictureBox Texture { get; }
        public string Name { get; set; }
        public Point Location
        {
            get
            {
                return Texture.Location;
            }

            set
            {
                Texture.Location = value;
            }
        }
        public bool IsWhite { get; }

        public Pawn(string Name, bool IsWhite, PictureBox Texture)
        {
            this.Name    = Name;
            this.Texture = Texture;
            this.IsWhite = IsWhite;

            Chessboard.ActivePawns.Add(this);
        }

        public void Move(int blockXCount, int blockYCount)
        {
            if (blockXCount > 7)
                blockXCount -= 7;
            else if (blockXCount < -7)
                blockXCount += 7;

            if (blockYCount > 7)
                blockYCount -= 7;
            else if (blockYCount < -7)
                blockYCount += 7;

            this.Location = new Point(this.Location.X + 94 * blockXCount, this.Location.Y + 94 * blockYCount);
        }

        public void SetLocation(int i, int j)
        {
            this.Location = new Point(Chessboard.ValidXLocations[i], Chessboard.ValidYLocations[j]);
        }

        public void SetLocation(Point p)
        {
            this.Location = p;
        }

        /// <summary>
        /// This method is called by any <see cref="Pawn"/> that destroys another <see cref="Pawn"/>.
        /// <list type="bullet">
        /// <item>The Pawn which called this method, moves to the destroyed Pawn's location</item>
        /// <item>The destroyed Pawn's Texture goes Invisible.</item>
        /// <item>The destroyed Pawn gets moved out from the <see cref="Chessboard"/>.</item>
        /// </list>
        /// </summary>
        /// <param name="ToDispose"></param>
        public void DisposePawn(Pawn ToDispose)
        {
            ToDispose.Texture.Visible = false;
            this.SetLocation(ToDispose.Location);
            ToDispose.Texture.Location = new Point(1000, 1000);

            Chessboard.ActivePawns.Remove(ToDispose);
        }

    }
}
