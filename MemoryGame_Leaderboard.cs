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

        private void buttonReturnToMenu_Click(object sender, EventArgs e)
        {
            new FormMemoryGame().Show();
            
            Close(); 
        }
    }
}
