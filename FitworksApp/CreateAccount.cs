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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            Center(this);

            //  textBox1.FlatAppearance.BorderSize = 0;
            label1.Parent = pictureBox1; 
            label1.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;

            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;

            label7.Parent = pictureBox1;
            label7.BackColor = Color.Transparent;

        }

        public void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            DataAccess db = new DataAccess();
          
            SetValueForFirstName = FirstNameTextBox.Text;
            SetValueForSurname = textBox2.Text;
            SetValueForEmail = emailTextBox.Text;
            SetValueForPassword = accountCreation_password2.Text;
            SetValueForDOB = DOB_textbox.Text;
           // Main.SetValueForMembershipColour = Color.Orange;  
            Main.SetValueForMembership = "Inactive";
            Main.SetValueForSession = "No Sessions"; 
            db.InsertNewAccount(SetValueForFirstName, SetValueForSurname, SetValueForEmail, SetValueForPassword, SetValueForDOB);
            MessageBox.Show("Account Created Successfully!");

            LoginForm f = new LoginForm();
            f.Show();
            this.Hide(); 

        }
        public static string SetValueForFirstName = "";
        public static string SetValueForSurname = "";
        public static string SetValueForEmail = "";
        public static string SetValueForPassword = "";
        public static string SetValueForDOB = "";
        public static int SetValueForId = 0;
        public bool EmailValidation()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(emailTextBox.ToString());
                var d = addr.Address == emailTextBox.ToString();
                return true;
            }
            catch
            {
                return false;
            }

        }
        private void PasswordCreation_textbox(object sender, EventArgs e) //pass1
        {

            accountCreation_password1.PasswordChar = '*';
        }
        public bool PasswordValidate()
        {

            string ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(accountCreation_password1.ToString()))
            {
                MessageBox.Show("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


            if (!hasLowerChar.IsMatch(accountCreation_password1.ToString()))
            {
                MessageBox.Show("Password should contain at least one lower case letter.");
                return false;
            }
            else if (!hasUpperChar.IsMatch(accountCreation_password1.ToString()))
            {
                MessageBox.Show("Password should contain at least one upper case letter.");
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(accountCreation_password1.ToString()))
            {
                MessageBox.Show("Password should not be lesser than 8 or greater than 15 characters.");
                return false;
            }
            else if (!hasNumber.IsMatch(accountCreation_password1.ToString()))
            {
                MessageBox.Show("Password should contain at least one numeric value.");
                return false;
            }

            else if (!hasSymbols.IsMatch(accountCreation_password1.ToString()))
            {
                MessageBox.Show("Password should contain at least one special case character.");
                return false;
            }
            else    
            {
                return true;
            }

        }
        private void PasswordCreation_testbox2(object sender, EventArgs e)
        {  
            accountCreation_password2.PasswordChar = '*';
        }
        public bool DOBvalidation()
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(DOB_textbox.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(DOB_textbox.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
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
        public bool isValidFirstName()
        {
            string text = FirstNameTextBox.Text;
            if (!Regex.Match(text, "^[A-Z][a-zA-Z]*$").Success)
            {
                return false;
            }
            return true; 
        }
        public bool isValidSurname()
        {
            string text = textBox2.Text;
            if (!Regex.Match(text, "^[A-Z][a-zA-Z]*$").Success)
            {
                return false;
            }
            return true;
        }

        private void accountCreation_password1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            
           
        }

        private void FirstNameTextBox_Enter(object sender, EventArgs e)
        {
        }

        private void FirstNameTextBox_Leave(object sender, EventArgs e)
        {
           
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
           

        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
           
        }

        private void accountCreation_password1_Enter(object sender, EventArgs e)
        {
        

        }

        private void accountCreation_password1_Leave(object sender, EventArgs e)
        {
            
        }

        private void accountCreation_password2_Enter(object sender, EventArgs e)
        {
            
        }

        private void accountCreation_password2_Leave(object sender, EventArgs e)
        {
           
        }

        private void DOB_textbox_Enter(object sender, EventArgs e)
        {
         
        }

        private void DOB_textbox_Leave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm f = new LoginForm();
            f.Show(); 
        }
    }
}
    

