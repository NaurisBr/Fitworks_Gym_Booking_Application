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

namespace FitworksApp
{
    public partial class CardDetails : Form
    {
        public CardDetails()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        //This method saves user card details from input fields like textboxes and stores them in the database 
        private void button1_Click(object sender, EventArgs e)
        {
         
            DataAccess db = new DataAccess();
            //if (ValidateCardNumber(textBox5.Text) && IsValidExpiryDate(textBox2.Text))
            //{
            SetValueForCardType = paymentComboBox.SelectedItem.ToString();
            SetValueForCardNumber = cardNumberTextBox.Text;
            SetValueForExpiryDate = expiryDateTextBox.Text;
            SetValueForCCV = ccvTextBox.Text;
            SetValueForDuration = durationComboBox.SelectedItem.ToString();
            SetValueForMembershipStatus = textBox1.Text;
            
            //this method inserts data from the parameter input fields into the database for each user 
            db.InsertNewCardDetails2(SetValueForCardType, SetValueForCardNumber, SetValueForExpiryDate, SetValueForCCV, SetValueForDuration, LoginForm.SetValueForText1, SetValueForMembershipStatus);
           // db.UpdateMembershipStatus(textBox1.Text); 
                //MessageBox.Show("Account Created Successfully!");

                this.Close();
                Summary summary = new Summary();
                summary.Show();

            //}
        }
         
        public static string SetValueForCardType = "";
        public static string SetValueForCardNumber = "";
        public static string SetValueForExpiryDate = "";
        public static string SetValueForCCV = "";
        public static string SetValueForDuration = "";
        public static string SetValueForMembershipStatus = "";

        public static int SetValueForId = 0;
        /// <summary>
        /// This method, like the ones before pulls details from the database and stores them into the menu side panel, and also making changes to the UI 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardDetails_Load(object sender, EventArgs e)
        {
            //changing text field styling
            Center(this);
            DataAccess db = new DataAccess();
            db.GetStatusAndSessionInfo();
            Summary s = new Summary();
            LoginForm f = new LoginForm();
            label10.Text = Main.SetValueForMembership;
            label3.Text = CreateAccount.SetValueForFirstName; 
           // label1.Text = Form1.SetValueForText1;
           
            userClassLabel.Text = Main.SetValueForSession;
            label10.ForeColor = Main.SetValueForMembershipColour;

            panel3.Hide();
            timeTableButton.TabStop = false;
            timeTableButton.FlatStyle = FlatStyle.Flat;
            timeTableButton.FlatAppearance.BorderSize = 0;

            optionsButton.TabStop = false;
            optionsButton.FlatStyle = FlatStyle.Flat;
            optionsButton.FlatAppearance.BorderSize = 0;

            accountButton.TabStop = false;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.FlatAppearance.BorderSize = 0;

            LogoutButton.TabStop = false;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.FlatAppearance.BorderSize = 0;

            helpButton.TabStop = false;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.FlatAppearance.BorderSize = 0;

            label10.BackColor = Main.SetValueForMembershipColourBack;


        }
        /// <summary>
        /// https://forums.asp.net/t/1641865.aspx?validate+credit+card+expiry+date+using+C+
        /// This method validates the card expiry date using regular expressions 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsValidExpiryDate(string input)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(input.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(input, "MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            if (!isValid)
            {
                //MessageBox.Show("nop");
                return false;
            }
            else
            {
                //MessageBox.Show("yup");
                return true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AccountSettings settings = new AccountSettings();
            settings.Show();
            this.Hide(); 
        }
        /// <summary>
        /// https://stackoverflow.com/questions/32959273/c-sharp-validating-user-input-like-a-credit-card-number
        /// Calculates the valid length and repetition characters for a card number to determine if it is valid  
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsValidCardNumber(string input)
        {
            int[] cardInt = new int[input.Length];
            for( int i=0; i < input.Length; i++)
            {
                cardInt[i] = (int)(input[i] - '0');
            }
            //starting from the right, double each other digit, if greater than 9, mod 10 and + 1 to remainer 
            for( int i= cardInt.Length - 2; i >= 0; i = i - 2)
            {
                int tempValue = cardInt[i];
                tempValue = tempValue * 2;
                if(tempValue > 9)
                {
                    tempValue = tempValue % 10 + 1;
                }
                cardInt[i] = tempValue; 
            }
            //Add up all digits
            int total = 0;
            for (int i = 0; i < cardInt.Length; i++)
            {
                total += cardInt[i]; 
            }
            //if number is multiple of 10, it is valid 
            if(total % 10 ==0)
            {
                return true; 
            }
            return false; 
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 531 && panel3.Width == 199)
            {

                panel3.Height = 531;
                panel3.Width = 10;
            }
            else
            {
                panel3.Height = 531;
                panel3.Width = 199;
            }
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void CardDetails_Click(object sender, EventArgs e)
        {
            if (panel3.Height == 531 && panel3.Width == 199)
            {

                panel3.Height = 531;
                panel3.Width = 1;
                panel3.Hide();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AccountSettings acc = new AccountSettings();
            acc.Show();
            this.Hide(); 
        }

        private void LogoutButton_Click_1(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.Show();
            this.Hide();     
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

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
    }
}
