using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Data.SqlClient;  
using FitworksApp.Properties;
using Dapper;

namespace FitworksApp
{
    public class DataAccess
    {
        public List<AccountInfo> GetAccounts(string email)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                var output = connection.Query<AccountInfo>($"select * from [Table]").ToList();
                return output;
            }
        }

        public void InsertNewAccount(string first_name, string Surname, string account_creation_email, string accountCreation_password2, string account_creation_DOB)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                // AccountInfo newAccount = new AccountInfo { email = account_creation_email, password = accountCreation_password2, dateOfBirth = account_creation_DOB };
                List<AccountInfo> accounts = new List<AccountInfo>();
                accounts.Add(new AccountInfo {name = first_name, surname = Surname, email = account_creation_email, password = accountCreation_password2, dateOfBirth = account_creation_DOB});
                //connection.Execute("dbo.LoginDB_Insert @email, @password, @dateOfBirth", accounts);
                connection.Execute("INSERT INTO[Table] (name, surname, email, password, dateOfBirth) VALUES(@name, @surname, @email, @password, @dateOfBirth)", accounts);
            }

        }
        public void InsertNewCardDetails(string card_Type, string card_Number, string expiry_date, string _ccv, string _duration)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                List<AccountInfo> accounts = new List<AccountInfo>();
                accounts.Add(new AccountInfo {cardType = card_Type, cardNumber = card_Number, expiryDate = expiry_date, ccv = _ccv, duration = _duration });
                connection.Execute("INSERT INTO[Table] (cardType, cardNumber, expiryDate, ccv, duration) VALUES(@cardType, @cardNumber, @expiryDate, @ccv, @duration)", accounts);
            }
                 
        }
        public void InsertNewCardDetails2(string card_Type, string card_Number, string expiry_date, string _ccv, string _duration, string _email, string _membershipStatus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                List<AccountInfo> accounts = new List<AccountInfo>();
                accounts.Add(new AccountInfo { f1 = card_Type, f2 = card_Number, f3 = expiry_date, f4 = _ccv, f5 = _duration, emailf = _email, membershipStatus = _membershipStatus});
                connection.Execute("INSERT INTO[Fail] (f1, f2, f3, f4, f5, emailf, membershipStatus) VALUES(@f1, @f2, @f3, @f4, @f5, @emailf, @membershipStatus)", accounts);
            }

        }
        public void InsertSessions(string _session1, string _email2)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                List<AccountInfo> accounts = new List<AccountInfo>();
                accounts.Add(new AccountInfo { Session1 = _session1, email2 = _email2 });
                connection.Execute("INSERT INTO[SessionsBooked] (Session1, email2) VALUES(@Session1,  @email2)", accounts);

            }
        }
        public void UpdateMembershipStatus(string _membershipStatus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                List<AccountInfo> accounts = new List<AccountInfo>();
                accounts.Add(new AccountInfo {membershipStatus = _membershipStatus });
                connection.Execute("Update Fail set membershipStatus= '" + _membershipStatus + "' where emailf='" + LoginForm.SetValueForText1 + "'   ;", accounts);
            }

        }

        public void UpdateSessionStatus(string sessionName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                List<AccountInfo> accounts = new List<AccountInfo>();
                accounts.Add(new AccountInfo { Session1 = sessionName });
                connection.Execute("Update SessionsBooked set Session1= '" + sessionName + "' where email2='" + LoginForm.SetValueForText1 + "'   ;", accounts);
            }

        }
      
        public void ButtonCheckForeachSession()
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            sql.Open();
            // (*) may give the 1/0's.. change it
            SqlCommand sqa = new SqlCommand("Select Session1 from [SessionsBooked] where email2 =@email2", sql);
            sqa.Parameters.AddWithValue("@email2", LoginForm.SetValueForText1);
            SqlDataReader da = sqa.ExecuteReader();
            class_booking c = new class_booking();
            
            if (da.Read())
            {
                //UpdateSessionStatus(str);
                Main.SetValueForSession = da.GetValue(0).ToString();
       
            }
            sql.Close(); 
        }
        public void UpdateSession2(string sessionName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                List<AccountInfo> accounts = new List<AccountInfo>();
                accounts.Add(new AccountInfo { Session1 = sessionName });
                connection.Execute("UPDATE SessionsBooked(Session1) VALUES (@Session1) WHERE Session1= '" + sessionName + "' where email2='" + LoginForm.SetValueForText1 + "'   ;", accounts);
            }
        }
        public void GetStatusAndSessionInfo()
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitWorksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            sql.Open();                                         // (*) may give the 1/0's.. change it
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From Table1 where email ='" + LoginForm.SetValueForText1 + "' and password = '" + LoginForm.SetValueForPass + "'", sql);

            SqlCommand sqa2 = new SqlCommand("Select f1, f2, f3, f4, f5, membershipstatus from [Fail] where emailf =@emailf", sql);
            sqa2.Parameters.AddWithValue("@emailf", LoginForm.SetValueForText1);
            SqlDataReader da = sqa2.ExecuteReader();

            while (da.Read())
            {
                //  label3.Text = CheckStatus();
                Main.SetValueForMembership = da.GetValue(5).ToString();
                if (da.GetValue(5).ToString() == "Active")
                {
                    Main.SetValueForMembershipColour = Color.White;
                    Main.SetValueForMembershipColourBack = Color.Green; 
                }
                else if(da.GetValue(5).ToString() == "Inactive")
                {
                    Main.SetValueForMembershipColour = Color.White;
                    Main.SetValueForMembershipColourBack = Color.Orange; 
                }
            }

            //MOST THINGS WORK BUT REQUIRE 2 CLICKS. SESSIONS ARE SOMETIMES REVERSED AND CONTAIN OTHER BUTTON MEANINGS 
            sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            sql.Open();
            // (*) may give the 1/0's.. change it
            SqlCommand sqa3 = new SqlCommand("Select Session1 from [SessionsBooked] where email2 =@email2", sql);
            sqa3.Parameters.AddWithValue("@email2", LoginForm.SetValueForText1);
            SqlDataReader da3 = sqa3.ExecuteReader();
            class_booking c = new class_booking();
            if (da3.Read())
            {
                //UpdateSessionStatus(str);
                Main.SetValueForSession = da3.GetValue(0).ToString();
                if(Main.SetValueForMembership == "Inactive")
                {
                    Main.SetValueForMembershipColourBack = Color.Orange;
                }
                else
                {
                    Main.SetValueForMembershipColourBack = Color.Green; 
                }
            }

            sql.Close();

        }
        public void LoginCheck(List<AccountInfo> ppl)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            sql.Open();
            SqlDataAdapter sqa = new SqlDataAdapter("Select count(*) From [Table] where email ='" + LoginForm.SetValueForText1 + "' and password = '" + LoginForm.SetValueForPass + "'", sql);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
          //  if (dt.Rows[0][0].ToString() == "1")
          //  {

                DataAccess db = new DataAccess();
                CreateAccount c = new CreateAccount();
                ppl = db.GetAccounts(CreateAccount.SetValueForEmail);
            
           // }
        }

    }
}

    

