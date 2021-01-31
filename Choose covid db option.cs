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

        private void addCovidCaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Covid_Insert cov = new Covid_Insert();
            cov.Show();
        }

        private void searchAndModifyCovidCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Modify_covid mc = new Modify_covid();
            mc.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quit covid case reports application?","Confirm",MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
                Close();

        }

        private void aboutTheApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to covid case reports application!\n\nSelect 'Database' option in the menustrip, in order to make an insertion or a modification in covid case reports.\n" +
            "More info for the insertion/modification can be found at the corresponding forms.\n\nPress the button bellow to visit the covid cases website.\nThere, you can have a look " +
            "at all case reports and at some statistics about them.\n\nSelect Quit to return back in the applications menu.","Info");
        }
        private void Choose_covid_db_option_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }
    }
}
