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

        private void AnyToolStripItemClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem ToolStripClicked = (ToolStripMenuItem)sender;

            switch (ToolStripClicked.Name)
            {
                case "MemoryGameItem":
                    MessageBox.Show("In the memory game, you can test your memory skills by clicking icons that are flipped. There is a countdown timer support, so you can test" +
                                    "your skills in a tight timespan!\n\nBy clicking an image you will be able to see it. Clicking another image will either make it disappear if it's" +
                                    " not the same with the previous one, or both will remain open if they're the same. One can win if they find all icons, and lose if their time runs out." +
                                    "\n\nHave fun playing!", "Memory Game Intro", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    break;
                case "ChessGameItem":
                    MessageBox.Show("In the chess game, after you type your nickname, you will be able to play chess in a board with a friend. Players can choose their time per turn, if they wish so." +
                                    "\n\nAlso, players move their pawns by clicking to select them and then clicking the block they want the pawn to move to (there are no rules). One can win, if they attack the " +
                                    "enemy king, or if their opponent's time runs out.\n\nHave fun playing!", "Chess Game Intro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                case "COVID19WebsiteItem":
                    MessageBox.Show("After you add COVID-19 cases, you'll be able to see them in the website. To add a COVID-19 case, you can click on the database menu strip item and then click Add a COVID case. You can, also, " +
                                    "modify COVID-19 cases, by entering one field to search in the database.\n\n" +
                                    "Every case is being recorded to a database. This database can be seen in the COVID-19 website, in which you can see in great detail, every COVID-19 case reported. Additional features, which include" +
                                    " sorting and percentage statistics, are also supported.", "COVID-19 Reporting Intro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
        }
    }
}
