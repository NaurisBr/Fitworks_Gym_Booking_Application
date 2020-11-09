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
using System.Reflection.Emit;

namespace FitworksApp
{ 
    public partial class AccountSettings : Form
    {
        public AccountSettings()
        {

            InitializeComponent();
            //   panel4.BackColor = Color.FromArgb(125, Color.Black);
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
          
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void texttbox1_leave(object sender, EventArgs e)
        {
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void surname_enter(object sender, EventArgs e)
        {
           
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main m = new Main();
            m.Show(); 
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox3_Leave_1(object sender, EventArgs e)
        {
           
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true; 
            this.Close();
            CardDetails details = new CardDetails();
            details.Show();  
        }

        public static bool button2WasClicked = false;

        /// <summary>
        /// Retreives membership status information from the DataAccess class. From this, the method pulls inofrmation from the database and 
        /// saves it in the forms pull out side panel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountSettings_Load(object sender, EventArgs e)
        {
            Center(this);

            DataAccess db = new DataAccess();
            db.GetStatusAndSessionInfo();
            Summary s = new Summary();
            LoginForm f = new LoginForm();
            label3.Text = Main.SetValueForMembership;
            nameLabel.Text = CreateAccount.SetValueForFirstName;
            userClassLabel.Text = Main.SetValueForSession;  
            label3.ForeColor = Main.SetValueForMembershipColour;
           // button3.BackColor = Color.Transparent; 

        
            panel3.Hide();
            timetableButton.TabStop = false;
            timetableButton.FlatStyle = FlatStyle.Flat;
            timetableButton.FlatAppearance.BorderSize = 0;

            accountButton.TabStop = false;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.FlatAppearance.BorderSize = 0;

            optionsButton.TabStop = false;
            optionsButton.FlatStyle = FlatStyle.Flat;
            optionsButton.FlatAppearance.BorderSize = 0;

            LogoutButton.TabStop = false;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.FlatAppearance.BorderSize = 0;

            LogoutButton.TabStop = false;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.FlatAppearance.BorderSize = 0;

            helpButton.TabStop = false;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.FlatAppearance.BorderSize = 0;

            label3.BackColor = Main.SetValueForMembershipColourBack;

            //Connection string used to access the local database 
            SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nauri\source\repos\FitworksApp\Database\UserAccountDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            sql.Open();                                         // (*) may give the 1/0's.. change it
            SqlCommand sqa = new SqlCommand("Select name, surname, email, password, dateOfBirth from [Table] where email =@email", sql); 
            sqa.Parameters.AddWithValue("@email", LoginForm.SetValueForText1);
            SqlDataReader da = sqa.ExecuteReader();
            SetValueForExpiredMembership = textBox1.Text;
            while (da.Read()) //While the connection is active, user information is pulled from the database and stored in a listbox 
            {

                this.userInfoListBox.Items.Add("Full Name: " + da.GetValue(0).ToString() + " " + da.GetValue(1).ToString());
                this.userInfoListBox.Items.Add("Email: " + da.GetValue(2).ToString());
                this.userInfoListBox.Items.Add("Date of Birth: " + da.GetValue(4).ToString());
            }
            sql.Close();
          //  panel4.Hide();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static bool button3WasClicked = false;
        public static string SetValueForExpiredMembership = ""; 
        private void button3_Click(object sender, EventArgs e)
        {
            button3WasClicked = true;
            Main m = new Main();
            m.ButtonClickColour = true;
            DataAccess db = new DataAccess();
           // Main.SetValueForMembershipColour = Color.Orange;
            db.UpdateMembershipStatus("Inactive");
          
            MessageBox.Show("Membership Cancelled Successfully");
            this.Close();
            Main m2 = new Main();
            m2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
      
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void panel4_Click(object sender, EventArgs e)
        {
          
        }

        private void AccountSettings_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 531 && panel3.Width == 199)
            {

                panel3.Height = 531;
                panel3.Width = 1;
                panel3.Hide();

            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click_1(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide(); 
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            class_booking c = new class_booking();
            c.Show();
            this.Hide(); 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
