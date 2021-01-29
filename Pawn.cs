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

        public Pawn(string Name, PictureBox Texture)
        {
            this.Name    = Name;
            this.Texture = Texture;
        }

        public void Move(int blockXCount, int blockYCount)
        {
            if (blockXCount > 7 || blockYCount > 7)
                return;

            this.Location = new Point(this.Location.X + 94 * blockXCount, this.Location.Y + 94 * blockYCount);
        }
    }
}
