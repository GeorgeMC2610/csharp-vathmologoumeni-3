using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Covid_Website
{
    public class Covid_statistics
    {
        GridView gridview; //gridview class variable

        public Covid_statistics(GridView gridview) //constructor
        {
            this.gridview = gridview;
        }
        
        public void genderStats(TextBox output) //function for gender stats
        {
            int man_count = 0, woman_count = 0; //variables to store the sum of man and woman reports

            //check each row's gender column.Depending on the content, add one to the corresponding counter

            for (int i = 0; i < gridview.Rows.Count; i++)
            {
                if (gridview.Rows[i].Cells[7].Text.Equals("Man"))
                    man_count++;
                else
                    woman_count++;
            }

            //Get the greater count's percentage
                     
            float max_percentage = 0;

            if(man_count > woman_count)
                max_percentage = ((float)man_count / (float)gridview.Rows.Count) * 100;
            else if (man_count < woman_count)           
                max_percentage = ((float)woman_count / (float)gridview.Rows.Count) * 100;
            else
            {
                //If both genders have the same reports

                output.Text = "Man and woman case reports, have the same amount";
                return;
            }

            //print the total of man and woman reports.
            //Print the maximum percantage value
            //Print which gender has more reports 

            output.Text = "Total of Man covid case reports: " + man_count.ToString() + "\nTotal of Woman covid case reports: " + woman_count.ToString() + "\n\n" +
            "Most case reports are " + (man_count > woman_count ? "men." : "womans.") + "They form a " + max_percentage.ToString("0.0") + "% of total reports.";
        }

        
        public void ageOrdateStats(String stats, TextBox output) //function for date/age stats.The age or date role depends on "stats" value
        {
            List<String> All_dates_or_ages = new List<String>(); //A list to store all the dates/ages of each line

            List<String> Dates_or_ages = new List<String>(); //A list to store each date/age only once

            List<int> counts = new List<int>(); //A list to store the count of each date/age

            int count = 0; //counter for each date/age

            int max_count = 0; //variable that stores the maximum count of a date/age

            String max_count_date_or_age = ""; //variable that stores the date/age that has the maximum count


            //Add every date or age in All_dates_or_ages list depending on the function role

            for (int i = 0; i < gridview.Rows.Count; i++)
            {
                if(stats.Equals("Dates"))
                    All_dates_or_ages.Add(gridview.Rows[i].Cells[3].Text); //dates are in the 4th column
                else if(stats.Equals("Ages"))
                    All_dates_or_ages.Add(gridview.Rows[i].Cells[8].Text); //ages are on the 9th column
            }


            //Check which dates/ages are not stored yet in Dates_or_ages list from All_dates_or_ages list, and add them.
            //If a date/age in All_dates_or_ages is already in Dates_or_ages, we check the next one from All_dates_or_ages

            for (int i = 0; i < gridview.Rows.Count; i++)
            {
                if (!Dates_or_ages.Contains(All_dates_or_ages[i]))
                    Dates_or_ages.Add(All_dates_or_ages[i]);
                else
                    continue;

                //count how many times current date/age appear in All_dates_or_ages

                foreach (String date in All_dates_or_ages)
                {
                    if (date.Equals(All_dates_or_ages[i]))
                        count++;
                }

                //if the count of the current date/age in All_dates_or_ages is greater than the max count

                if (count > max_count)
                {
                    //update the max_count and the max_count_date_or_age

                    max_count = count;
                    max_count_date_or_age = All_dates_or_ages[i];
                }

                //print the current date's/age's count

                if (stats.Equals("Dates"))
                    output.Text += "Total covid cases in " + All_dates_or_ages[i] + ": " + count.ToString() + "\n";
                else if(stats.Equals("Ages"))
                    output.Text += "Total covid cases at age " + All_dates_or_ages[i] + ": " + count.ToString() + "\n";

                counts.Add(count); //add the current date/age count in counts list
                count = 0; //set the count=0 and continue with the next All_dates_or_ages value

            }

            //if there is atleast two counts that are different,print the maximum count's percentage and the date/age that has that percentage

            foreach (int c in counts)
            {
                if (counts[0] != c)
                {
                    float max_percentage = ((float)max_count / (float)gridview.Rows.Count) * 100;

                    if(stats.Equals("Dates"))
                        output.Text += "\nMost cases have been reported in " + max_count_date_or_age + ".The " + max_percentage.ToString("0.0") + "% of total reports, have been reported that day.";
                    else if(stats.Equals("Ages"))
                        output.Text += "\nMost case reports have an age of " + max_count_date_or_age + ".They form a " + max_percentage.ToString("0.0") + "% of total reports.";

                    return;
                }
            }

            //if all the counts are equal

            if (stats.Equals("Dates"))
                output.Text += "\nAll dates have the same amount of reports.";
            else if (stats.Equals("Ages"))
                output.Text += "\nAll ages have the same amount of reports.";
        }

    }
}