﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Covid_Website
{
    public partial class WebForm1 : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "Covid case reports until today: " + GridView1.Rows.Count.ToString();

            Covid_statistics stats = new Covid_statistics(GridView1);
            stats.ageStats(TextBox1);

        }
    }
}