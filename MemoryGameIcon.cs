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
        private PictureBox DefaultIcon { get; }
        private PictureBox QuestionMark { get; }
        public bool Selected { get; set; }
        public static List<MemoryGameIcon> AllIcons = new List<MemoryGameIcon>();
        
        public MemoryGameIcon(PictureBox Icon)
        {
            VisibleIcon        = Icon;
            DefaultIcon        = new PictureBox();
            DefaultIcon.Image  = Icon.Image;
            QuestionMark       = new PictureBox();
            QuestionMark.Image = Properties.Resources.questionmark;
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
            AllIcons.ForEach(i => i.VisibleIcon = i.QuestionMark);
        }

        public static void ShowAllIcons()
        {
            AllIcons.ForEach(i => i.VisibleIcon = i.DefaultIcon);
        }
        
        public static void RandomizeLocationImages()
        {
            Random random = new Random();

            for (int i = 1; i < AllIcons.Count; i++)
            {
                int rand = random.Next(2);
                if (rand == 1)
                {
                    Point temp = AllIcons[i].VisibleIcon.Location;
                    AllIcons[i].VisibleIcon.Location = AllIcons[0].VisibleIcon.Location;
                    AllIcons[0].VisibleIcon.Location = temp;
                }
            }

            for (int i = 0; i < AllIcons.Count - 1; i++)
            {
                int rand = random.Next(2);
                if (rand == 1)
                {
                    Point temp                                        = AllIcons[i].VisibleIcon.Location;
                    AllIcons[i].VisibleIcon.Location                  = AllIcons[AllIcons.Count - 1].VisibleIcon.Location;
                    AllIcons[AllIcons.Count - 1].VisibleIcon.Location = temp;
                }
            }
        }
    }
}
