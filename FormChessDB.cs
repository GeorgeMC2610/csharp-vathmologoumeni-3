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
    public partial class FormChessDB : Form
    {
        public FormChessDB()
        {
            InitializeComponent();
        }

        private void gamesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gamesBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.chessGamesDataSet);

        }

        private void FormChessDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chessGamesDataSet.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.chessGamesDataSet.Games);

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormChessDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();
        }
    }
}
