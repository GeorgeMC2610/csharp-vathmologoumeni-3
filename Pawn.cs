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

        public void Move(int dx, int dy)
        {
            dx += this.Location.X;
            dy += this.Location.Y;

            this.Location = new Point(dx, dy);
        }
    }
}
