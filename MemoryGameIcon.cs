using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_3
{
    class MemoryGameIcon
    {
        public PictureBox VisibleIcon { get; set; }
        public PictureBox DefaultIcon { get; }
        public PictureBox QuestionMark { get; }
        public string Name { get; set; }
        public bool Revealed { get; set; }
        public bool Selected { get; set; }
        public static List<MemoryGameIcon> AllIcons = new List<MemoryGameIcon>();
        public static int FoundImages = 0;
        
        public MemoryGameIcon(PictureBox Icon, string Name)
        {
            VisibleIcon         = Icon;
            DefaultIcon         = new PictureBox();
            DefaultIcon.Image   = Icon.Image;
            QuestionMark        = new PictureBox();
            this.Name           = Name;
            QuestionMark.Image  = Properties.Resources.questionmark;
            Revealed = Selected = false;
            AllIcons.Add(this);
        }

        public void HideIcon()
        {
            this.VisibleIcon.Image = QuestionMark.Image;
        }

        public void ShowIcon()
        {
            this.VisibleIcon.Image = DefaultIcon.Image;
        }

        public static void HideAllIcons()
        {
            AllIcons.Where(i => !(i.Revealed || i.Selected)).ToList().ForEach(i => i.HideIcon());
        }

        public static void ShowAllIcons()
        {
            AllIcons.ForEach(i => i.ShowIcon());
        }
        
        public static void RandomizeLocationImages()
        {
            Random random = new Random();

            int i = AllIcons.Count;
            while (i > 1)
            {
                i--;
                int n = random.Next(i + 1);
                Point temp                       = AllIcons[n].VisibleIcon.Location;
                AllIcons[n].VisibleIcon.Location = AllIcons[i].VisibleIcon.Location;
                AllIcons[i].VisibleIcon.Location = temp;
            }
        }
    }
}
