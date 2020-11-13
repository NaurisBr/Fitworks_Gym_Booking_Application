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
using System.Data;

namespace FitworksApp
{
    public partial class Summary : Form
    {
        List<AccountInfo> people = new List<AccountInfo>();
        //private BindingList<string> items = new BindingList<string>();
        public Summary()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }
        /// <summary>
        ///  Retreives membership status information from the DataAccess class. From this, the method pulls inofrmation from the database and
        ///  saves it in the forms pull out side panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Summary_Load(object sender, EventArgs e)
        {
            Center(this);

            DataAccess db = new DataAccess();
            db.GetStatusAndSessionInfo();
            Summary s = new Summary();
            LoginForm f = new LoginForm();
            label3.Text = Main.SetValueForMembership;
            userNameLabel.Text = CreateAccount.SetValueForFirstName; 
            userClassLabel.Text = Main.SetValueForSession;
            label3.ForeColor = Main.SetValueForMembershipColour;
            label3.BackColor = Main.SetValueForMembershipColourBack;

            panel3.Hide();
            timetableButton.TabStop = false;
            timetableButton.FlatStyle = FlatStyle.Flat;
            timetableButton.FlatAppearance.BorderSize = 0;

            panel3.Hide();
            accountButton.TabStop = false;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.FlatAppearance.BorderSize = 0;

            panel3.Hide();
            optionsButton.TabStop = false;
            optionsButton.FlatStyle = FlatStyle.Flat;
            optionsButton.FlatAppearance.BorderSize = 0;

            panel3.Hide();
            helpButton.TabStop = false;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.FlatAppearance.BorderSize = 0;

            panel3.Hide();
            LogoutButton.TabStop = false;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.FlatAppearance.BorderSize = 0;



            //Connection string used to access the local database 
            SqlConnection sql = new SqlConnection(DataAccess.ConnString);
            sql.Open();
            SqlCommand sqa = new SqlCommand("Select f1, f2, f3, f4, f5, membershipstatus from [Fail] where emailf =@emailf", sql);
            sqa = new SqlCommand("Select f1, f2, f3, f4, f5, membershipstatus from [Fail] where emailf =@emailf", sql);
            sqa.Parameters.AddWithValue("@emailf", LoginForm.SetValueForText1);
            SqlDataReader da = sqa.ExecuteReader();

            while (da.Read()) //While the connection is active, user information is pulled from the database and stored in a listbox 
            {
                AccountSettings.button3WasClicked = false;
                this.summaryListBox.Items.Add("Duration: " + da.GetValue(4).ToString());
                this.summaryListBox.Items.Add("Payment: " + da.GetValue(0).ToString());
                this.summaryListBox.Items.Add("Card Number: " + MaskCardNumber(CardDetails.SetValueForCardNumber));
                this.summaryListBox.Items.Add("Expiry Date: " + da.GetValue(2).ToString());
                //this.summaryListBox.Items.Add("CCV: " + da.GetValue(3).ToString());
                
              
            }
            sql.Close();


          
        }
        private void button4_Click(object sender, EventArgs e)
        {     
        }

        public void UpdateBinding()
        {
           // this.listBox1.DataSource = people;
            this.summaryListBox.DisplayMember = "FullInfo";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static bool buttonWasClicked = false;
        public static string SetMembershipFromSummary = "";
        private void button1_Click(object sender, EventArgs e)
        {

            buttonWasClicked = true;
          
            Main m = new Main();
            m.Show();
            this.Hide();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Main m = new Main();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CardDetails details = new CardDetails();
            details.Show();
            this.Hide(); 
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AccountSettings acc = new AccountSettings();
            acc.Show();
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel3.Height = 531;
            panel3.Width = 199;
            panel3.Show();
        }

        private void Summary_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 531 && panel3.Width == 199)
            {

                panel3.Height = 531;
                panel3.Width = 1;
                panel3.Hide();

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            class_booking c = new class_booking();
            c.Show();
            this.Hide(); 

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        public string MaskCardNumber(string num)
        {
            string text = num;
            if (text.Length > 4)
                return num = text.Substring(text.Length - 4).PadLeft(text.Length, 'X');
            return "";
        }
      
    
    }
}
