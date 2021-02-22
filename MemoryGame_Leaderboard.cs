using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_3
{
    public partial class MemoryGame_Leaderboard : Form
    {
        public MemoryGame_Leaderboard()
        {
            InitializeComponent();
        }

        private void MemoryGame_Leaderboard_Load(object sender, EventArgs e)
        {
            string stats = MemoryGameIO.LoadStats();

            if (stats.Equals("empty"))
            {
                richTextBoxLeaderboards.Text = "Something went wrong while trying to load stats. Check if the leaderboards.txt file is present in bin/Debug.";
                return;
            }

            string[] leaderboards = stats.Split('\n');
            foreach (string stat in leaderboards)
            {
                string[] attributes = stat.Split('|');

                if (attributes.Length != 5)
                    return;


            }
        }

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            new FormMemoryGame().Show();
            Close(); 
        }
    }
}
