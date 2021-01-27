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
    public partial class FormChess : Form
    {
        public FormChess()
        {
            InitializeComponent();
        }

        private void AnyButtonClicked(object sender, EventArgs e)
        {
            Button pressed = (Button)sender;

            switch (pressed.Name)
            {
                case "buttonExit":
                    Application.OpenForms[0].Show();
                    Close();
                    break;
            }
        }
    }
}
