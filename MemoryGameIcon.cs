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
        public PictureBox VisibleIcon { get; set; }
        private PictureBox DefaultIcon { get; }
        private PictureBox QuestionMark { get; }
        public bool Selected { get; set; }
        public static List<MemoryGameIcon> AllIcons = new List<MemoryGameIcon>();
        
        public MemoryGameIcon(PictureBox Icon)
        {
            VisibleIcon  = Icon;
            DefaultIcon       = new PictureBox();
            DefaultIcon.Image = Icon.Image;
            QuestionMark = new PictureBox();
            QuestionMark.Image = Properties.Resources.questionmark;
            AllIcons.Add(this);
        }

        public void HideIcon()
        {
            this.VisibleIcon = QuestionMark;
        }

        public void ShowIcon()
        {
            this.VisibleIcon = DefaultIcon;
        }

        public static void HideAllIcons()
        {
            AllIcons.ForEach(i => i.VisibleIcon = i.QuestionMark);
        }

        public static void ShowAllIcons()
        {
            AllIcons.ForEach(i => i.VisibleIcon = i.DefaultIcon);
        }
    }
}
