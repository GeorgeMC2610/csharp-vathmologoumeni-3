using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_vathmologoumeni_3
{
    static class MemoryGameIO
    {
        public static void SaveGame(string name, int pairs, int tries, int timeInitial, int timeRemaining)
        {
            try
            {
                StreamWriter sw = new StreamWriter("leaderboards.txt", true, Encoding.UTF8);
                string textToWrite = name + "|" + pairs.ToString() + "|" + tries.ToString() + "|" + timeInitial.ToString() + "|" + timeRemaining.ToString();
                sw.WriteLine(textToWrite);
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to save game.\n\nException Error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string LoadStats()
        {
            try
            {
                StreamReader sr = new StreamReader("leaderboards.txt");
                string Stats = sr.ReadToEnd();
                return Stats;
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to load stats.\n\nException Error: " + e.Message);
                return "empty";
            }
        }
    }
}
