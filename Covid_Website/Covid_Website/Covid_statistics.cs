using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Covid_Website
{
    public class Covid_statistics
    {
        GridView gridview;

        public Covid_statistics(GridView gridview)
        {
            this.gridview = gridview;
        }

        public void ageStats(TextBox output)
        {

            List<String> All_ages = new List<String>();
            List<String> Ages = new List<String>();
            int count = 0;
            int max_count = 0;
            String max_count_age = "";
                
            for(int i = 0; i< gridview.Rows.Count; i++)
            {
                All_ages.Add(gridview.Rows[i].Cells[8].Text);
            }

            for (int i = 0; i < gridview.Rows.Count; i++)
            {
                if (!Ages.Contains(All_ages[i]))
                {
                    Ages.Add(All_ages[i]);
                }
                else
                {
                    continue;
                }

                foreach (String age in All_ages)
                {
                    if (age.Equals(All_ages[i]))
                        count++;
                }

                if (count > max_count)
                {
                    max_count = count;
                    max_count_age = All_ages[i];
                }
                    
                output.Text += "Total covid cases at age " + All_ages[i] + ": " + count.ToString() + "\n";
                count = 0;

            }

            float max_percentage = ((float)max_count / (float)gridview.Rows.Count)*100;

            output.Text += "\nMost case reports have an age of " + max_count_age + ".They form a " + max_percentage.ToString() + "% of total reports.";

        }
    }
}