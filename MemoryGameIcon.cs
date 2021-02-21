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
        public static List<MemoryGameIcon> AllIcons = new List<MemoryGameIcon>();
        
        public MemoryGameIcon(PictureBox Icon)
        {
            this.Icon = Icon;
            AllIcons.Add(this);
        }

        public void HideIcon()
        {
            this.Icon.ImageLocation = "questionmark.png";
        }
    }
}
