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
    public partial class Covid : Form
    {
        public Covid()
        {
            InitializeComponent();
        }

        private void Covid_Load(object sender, EventArgs e)
        {
            DateTime date_now = DateTime.Now; //get current date time
            String now = date_now.ToString(); //convert to string

            if (now.Contains("μμ")) //replace greek chars with english chars
                now = now.Replace("μμ", "pm");
            else
                now = now.Replace("πμ", "am");

            textBox6.Text = now; //set textbox text to current time
        }
    }
}
