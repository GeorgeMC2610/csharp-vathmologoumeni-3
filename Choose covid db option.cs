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
    public partial class Choose_covid_db_option : Form
    {
        public Choose_covid_db_option()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Covid_Insert cov = new Covid_Insert();
            cov.Show();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Modify_covid mc = new Modify_covid();
            mc.Show();
        }
        private void Choose_covid_db_option_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
