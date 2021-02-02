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
        
        public void genderStats(TextBox output)
        {
            int man_count = 0, woman_count = 0;

            for (int i = 0; i < gridview.Rows.Count; i++)
            {
                if (gridview.Rows[i].Cells[7].Text.Equals("Man"))
                    man_count++;
                else
                    woman_count++;
            }

            float max_percentage = 0;

            if(man_count > woman_count)
                max_percentage = ((float)man_count / (float)gridview.Rows.Count) * 100;
            else if (man_count < woman_count)           
                max_percentage = ((float)woman_count / (float)gridview.Rows.Count) * 100;
            else
            {
                output.Text = "Man and woman case reports, have the same amount";
                return;
            }

            output.Text = "Total of Man covid case reports: " + man_count.ToString() + "\nTotal of Woman covid case reports: " + woman_count.ToString() + "\n\n" +
            "Most case reports are " + (man_count > woman_count ? "mans." : "womans.") + "They form a " + max_percentage.ToString() + "% of total reports.";
        }

        
        public void ageOrdateStats(String stats, TextBox output)
        {
            List<String> All_dates_or_ages = new List<String>();
            List<String> Dates_or_ages = new List<String>();
            List<int> counts = new List<int>();
            int count = 0;
            int max_count = 0;
            String max_count_date_or_age = "";

            for (int i = 0; i < gridview.Rows.Count; i++)
            {
                if(stats.Equals("Dates"))
                    All_dates_or_ages.Add(gridview.Rows[i].Cells[3].Text);
                else if(stats.Equals("Ages"))
                    All_dates_or_ages.Add(gridview.Rows[i].Cells[8].Text);
            }

            for (int i = 0; i < gridview.Rows.Count; i++)
            {
                if (!Dates_or_ages.Contains(All_dates_or_ages[i]))
                {
                    Dates_or_ages.Add(All_dates_or_ages[i]);
                }
                else
                {
                    continue;
                }

                foreach (String date in All_dates_or_ages)
                {
                    if (date.Equals(All_dates_or_ages[i]))
                        count++;
                }

                if (count > max_count)
                {
                    max_count = count;
                    max_count_date_or_age = All_dates_or_ages[i];
                }

                if (stats.Equals("Dates"))
                    output.Text += "Total covid cases in " + All_dates_or_ages[i] + ": " + count.ToString() + "\n";
                else if(stats.Equals("Ages"))
                    output.Text += "Total covid cases at age " + All_dates_or_ages[i] + ": " + count.ToString() + "\n";

                counts.Add(count);
                count = 0;

            }

            foreach (int c in counts)
            {
                if (counts[0] != c)
                {
                    float max_percentage = ((float)max_count / (float)gridview.Rows.Count) * 100;

                    if(stats.Equals("Dates"))
                        output.Text += "\nMost cases have been reported in " + max_count_date_or_age + ".The " + max_percentage.ToString() + "% of total reports, have been reported that day.";
                    else if(stats.Equals("Ages"))
                        output.Text += "\nMost case reports have an age of " + max_count_date_or_age + ".They form a " + max_percentage.ToString() + "% of total reports.";

                    return;
                }
            }

            if (stats.Equals("Dates"))
                output.Text += "\nAll dates have the same amount of reports.";
            else if (stats.Equals("Ages"))
                output.Text += "\nAll ages have the same amount of reports.";
        }

    }
}