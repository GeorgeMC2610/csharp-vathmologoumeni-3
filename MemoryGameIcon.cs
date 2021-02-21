using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_3
{
    class MemoryGameIcon
    {
        public PictureBox Icon { get; }
        public bool Selected { get; set; }
        
        public MemoryGameIcon(PictureBox Icon)
        {
            this.Icon = Icon;
        }

    }
}
