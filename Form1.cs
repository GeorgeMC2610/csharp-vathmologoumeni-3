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

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            labelTitle.Location    = new Point(Width / 2 - labelTitle.Width / 2, labelTitle.Location.Y);
            labelSubtitle.Location = new Point(Width / 2 - labelSubtitle.Width / 2, labelSubtitle.Location.Y);
        }

        private void AnyButtonClicked(object sender, EventArgs e)
        {
            Button ButtonClicked = (Button)sender;

            Hide();

            switch (ButtonClicked.Name)
            {
                case "buttonMemoryGame":
                    new FormMemoryGame().Show();
                    break;

                case "buttonSkakiera":
                    new FormChess().Show();
                    break;

                case "buttonCovid":
                    new Choose_covid_db_option().Show();
                    break;
            }
        }
    }
}
