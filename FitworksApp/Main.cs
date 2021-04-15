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
using System.Data.SqlTypes;

namespace FitworksApp
{
    public partial class Main : Form
    {
        DataAccess db = new DataAccess();
        // All new users are stored in a peoples list and pulled when neccessary 
        List<AccountInfo> people = new List<AccountInfo>(); 
        public Main()
        {
            Summary s = new Summary();
            InitializeComponent();
            shadowPanel.BackColor = Color.FromArgb(125, Color.Black);
            s.UpdateBinding();
            db.GetStatusAndSessionInfo();
            this.StartPosition = FormStartPosition.CenterScreen;

        }//Adding comments to main
        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Retrieves settings from the database, i.e. membership status for each user and the sessions that they have booked.
        /// Slider menu components are changed to suit the apps conventions  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Main_Load(object sender, EventArgs e)
        {
            Center(this); 
            Summary s = new Summary();
            LoginForm f = new LoginForm();
            //Changing button appearance
            label3.Text = SetValueForMembership;
            label1.Text = CreateAccount.SetValueForFirstName;
            label5.Text = SetValueForSession;
            label3.ForeColor = SetValueForMembershipColour;
            label3.BackColor = SetValueForMembershipColourBack;
            findAClassButton.FlatAppearance.BorderSize = 0; 
            DataAccess db = new DataAccess();
            shadowPanel.Hide();
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button7.TabStop = false;
            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;

            button8.TabStop = false;
            button8.FlatStyle = FlatStyle.Flat;
            button8.FlatAppearance.BorderSize = 0;

            LogoutButton.TabStop = false;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.FlatAppearance.BorderSize = 0;

            LogoutButton.TabStop = false;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.FlatAppearance.BorderSize = 0;

            button6.TabStop = false;
            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;

       
        }

        public void button2_Click(object sender, EventArgs e)
        {
           
           
        }

        //Creating temporary variables as place holders for user data
        public bool ButtonClickColour = false; 
        public static string SetValueForText = "";
        public static string SetValueForMembership = "";
        public static Color SetValueForMembershipColour = Color.White;
        public static Color SetValueForMembershipColourBack = Color.Orange;
        public static string SetValueForSession = "";

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {       
            this.Close();
            LoginForm f = new LoginForm();
            f.Show(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AccountSettings acc = new AccountSettings();
            acc.Show(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Updating membership status 
            class_booking book = new class_booking();
            if(label3.Text == "Inactive")
            {
                MessageBox.Show("You must have an Active membership");
            }
            else
            {
                book.Show();
                this.Hide();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Retracts slider menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
         
                panel3.Height = 531;
                panel3.Width = 199;
                shadowPanel.Show(); 
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {//Re-adjusting panel width for main page
             
            if (panel3.Height == 531 && panel3.Width == 199)
            {
                
                panel3.Height = 531;  
                panel3.Width = 1;
                shadowPanel.Hide(); 
              
            }
          

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            class_booking book = new class_booking();
            book.Show();
            this.Hide(); 
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            MyClasses classes = new MyClasses();
            classes.Show();
            this.Hide(); 
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
