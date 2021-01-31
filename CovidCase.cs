using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace csharp_vathmologoumeni_3
{
    class CovidCase
    {
        public String Full_name,Email,Date_of_record,Time_of_record,Phone_number,Home_address,Gender,Age;
        String[] Underlying_diseases;

        static OleDbConnection connection = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = Covid_cases.mdb;");

        //constructor for insert/modify

        public CovidCase(String Full_name, String Email, String[] Underlying_diseases, String Date_of_record, String Time_of_record, String Phone_number, String Home_address, String Gender, String Age)
        {
            this.Full_name = Full_name;
            this.Email = Email;
            this.Underlying_diseases = Underlying_diseases;
            this.Date_of_record = Date_of_record;
            this.Time_of_record = Time_of_record;
            this.Phone_number = Phone_number;
            this.Home_address = Home_address;
            this.Gender = Gender;
            this.Age = Age;
        }

        public CovidCase(String Email) //constructor for delete
        {
            this.Email = Email;
        }

        private void databaseFunction(String function,String old_email)
        {
            connection.Open();

            OleDbCommand comand;

            if (function.Equals("Insert"))
            {
                comand = new OleDbCommand("Insert into Covid_cases(Full_name,Email,Underlying_diseases,Date_of_record," +
                "Time_of_record,Phone_number,Home_address,Gender,Age) values(@fn,@email,@ud,@dor,@tor,@pn,@ha,@gender,@age)", connection);
            }
            else
            {
                comand = new OleDbCommand("Update Covid_cases set Full_name = @fn, Email = @email, Underlying_diseases=@ud, Date_of_record=@dor, " +
                "Time_of_record=@tor, Phone_number=@pn, Home_address=@ha, Gender=@gender, Age=@age where Email = @oldemail", connection);
            }

            comand.Parameters.AddWithValue("@fn", Full_name);
            comand.Parameters.AddWithValue("@email", Email);

            StringBuilder diseases = new StringBuilder("");

            if (Underlying_diseases.Length != 0)
            {
                foreach (String disease in Underlying_diseases)
                {
                    diseases.Append(disease);
                    diseases.Append(", ");
                }
                diseases.Remove(diseases.Length - 2, 2);
            }
            else
                diseases.Append("none");

            comand.Parameters.AddWithValue("@ud", diseases.ToString());
            comand.Parameters.AddWithValue("@dor", Date_of_record);
            comand.Parameters.AddWithValue("@tor", Time_of_record);
            comand.Parameters.AddWithValue("@pn", Phone_number);
            comand.Parameters.AddWithValue("@ha", Home_address);
            comand.Parameters.AddWithValue("@gender", Gender);
            comand.Parameters.AddWithValue("@age",Age);

            if (function.Equals("Update"))           
                comand.Parameters.AddWithValue("@oldemail", old_email);

            comand.ExecuteNonQuery();

            connection.Close();
        }

        public void deleteCase()
        {
            connection.Open();

            OleDbCommand delete = new OleDbCommand("Delete from Covid_cases where Email = @email", connection);
            delete.Parameters.AddWithValue("@email", Email);
            delete.ExecuteNonQuery();

            connection.Close();
        }

        public void insertCase()
        {
            this.databaseFunction("Insert", "");          
        }

        public void updateCase(String old_email)
        {
            this.databaseFunction("Update",old_email);        
        }
    }
}
