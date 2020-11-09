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


    public partial class LoginForm : Form
    {
        DataAccess db = new DataAccess();
        List<AccountInfo> people = new List<AccountInfo>();
        public LoginForm()
        {
            Summary s = new Summary();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            s.UpdateBinding();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.StartPosition = FormStartPosition.CenterScreen;


        }
        /// <summary>
        /// Centers the form to the middle of the screen
        /// </summary>
        /// <param name="LoginForm"></param>
        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }

        /// <summary>
        /// Adjusts the UI appearance of textboxes and buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)     
        {
            Center(this); 
            Summary s = new Summary();
            logo.Parent = loginBackgroundImage;
            logo.BackColor = System.Drawing.Color.Transparent;

            forgetPasswordLabel.Parent = loginBackgroundImage;
            forgetPasswordLabel.BackColor = System.Drawing.Color.Transparent;

            registerButton.Parent = loginBackgroundImage;
            registerButton.BackColor = System.Drawing.Color.Transparent;

            registerButton.Parent = loginBackgroundImage;
            registerButton.BackColor = System.Drawing.Color.Transparent;

            if(emailLogin_textbox.Text == "Email")
            {
                emailLogin_textbox.ForeColor = Color.Gray; 
            }

            if (passwordLoginTextBox.Text == "Password")
            {
                passwordLoginTextBox.ForeColor = Color.Gray;
            }

            LogInButtonX.FlatAppearance.BorderSize = 0;
         


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccountButton(object sender, EventArgs e)
        {
            

        }
        

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {


        }

      

       

      

        private void PasswordLogin_textbox(object sender, EventArgs e)
        {
           // accountCreation_password2.PasswordChar = '*';
           
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                
        }


        private void LoginButton1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Creates an instance of a new form and assigns respective account creation fields to log in fields for a match 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInButtonX_Click(object sender, EventArgs e)
        {

            SetValueForText1 = emailLogin_textbox.Text;
            SetValueForPass = passwordLoginTextBox.Text;
           
            DataAccess db = new DataAccess();
            db.LoginCheck(people);
            Main m = new Main();
            m.Show();
            this.Hide();

        }
 



        /// <summary>
        /// Retreives only the name from an email address so that the user can be greeted when logged on 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string NameAlone(string str)
        {
            string name = "";
            string[] arr1 = new string[] { str };
            for (int i = 0; i < arr1.Length; i++)   
            {      
                string[] words = arr1[i].Split('@');
                for (int j = 0; j < words.Length; j++)
                {
                    name = words[0];
                    name.Substring(0).ToUpper();
                    return "Welcome, " + char.ToUpper(name[0]) + name.Substring(1) + "!";
                }
                return name;
            }
            return name;
        }
        public static string SetValueForText1 = "";
        public static string SetValueForPass = "";
        public static string SetValueForName = "";



        private void textBox6_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            CreateAccount acc = new CreateAccount();
            acc.Show();
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
         
        }

        private void emailLogin_textbox_Enter(object sender, EventArgs e)
        {
            emailLogin_textbox.Text = ""; 
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
          
            passwordLoginTextBox.Text = ""; 
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (passwordLoginTextBox.Text == "")
            {
                passwordLoginTextBox.Text = "Password";
            }
        }

        private void emailLogin_textbox_Leave(object sender, EventArgs e)
        {
            if (emailLogin_textbox.Text == "")
            {
                emailLogin_textbox.Text = "Email";
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void customButton1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_3(object sender, EventArgs e)
        {

        }
    }
}
