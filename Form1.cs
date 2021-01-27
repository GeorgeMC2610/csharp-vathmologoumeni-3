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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Covid().Show();
        }

        private void buttonSkakiera_Click(object sender, EventArgs e)
        {
            Hide();
            new FormChess().Show();
        }

        private void buttonMemoryGame_Click(object sender, EventArgs e)
        {
            Hide();
            new FormMemoryGame().Show();
        }
    }
}
