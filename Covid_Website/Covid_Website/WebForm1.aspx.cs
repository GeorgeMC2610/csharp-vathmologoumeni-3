using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Speech.Synthesis;

namespace Covid_Website
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) //on page load
        {
            TextBox1.Text = TextBox2.Text = TextBox3.Text = "";

            Label2.Text = "Covid case reports until today: " + GridView1.Rows.Count.ToString(); //mention the sum of the reports(number of table rows)

            Covid_statistics stats = new Covid_statistics(GridView1); //make a Covid_statistics(custom class) object that takes the gridview as constructor parameter

            //Covid_statistics member functions.Each function takes as a parameter the output textbox to store the results

            stats.ageOrdateStats("Ages", TextBox1);
            stats.genderStats(TextBox2);
            stats.ageOrdateStats("Dates", TextBox3);
        }
    }
}