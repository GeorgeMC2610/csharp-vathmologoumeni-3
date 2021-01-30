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
    public partial class FormMemoryGame : Form
    {
        public static int random;
        public FormMemoryGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Lets_Play_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Close();
        }
    }
}
