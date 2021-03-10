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
    public partial class class_booking : Form
    {
        public class_booking()
        {
            DataAccess db = new DataAccess();
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
        }
        /// <summary>
        /// This method is used for updating sessions to see which have expired. It is also used for adding new sessions to a users database and saving them
        /// As the previous forms, some of this code is used to improve the appearance of the UI for the slide panel menu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void class_booking_Load(object sender, EventArgs e)
        {

            Center(this);

            DataAccess db = new DataAccess();
            db.GetStatusAndSessionInfo();
            dateTimeLabel.Text = DateTime.Now.ToString("dddd, dd MMMM");
            GetSessionInfoAAndValidation();
            Main m = new Main();
            db.InsertSessions("Session Not Selected", LoginForm.SetValueForText1);
            
            Summary s = new Summary();
            LoginForm f = new LoginForm();
            label6.Text = Main.SetValueForMembership; //Value for membership is always set in the slider menu when it is created 
            label1.Text = CreateAccount.SetValueForFirstName; //First name appears in the slide menu to greet the user 
            dateTimeLabel.Text = DateTime.Now.ToString();   //Shows current time, great for booking sessions 
            label6.ForeColor = Main.SetValueForMembershipColour;
            userClassLabel.Text = Main.SetValueForSession;

            sliderPanel.Hide();
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

            helpButton.TabStop = false;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.FlatAppearance.BorderSize = 0;

            label6.BackColor = Main.SetValueForMembershipColourBack;


        }
      

        public object IsExpiredSlot(TimeSpan ts, string textbox)
        {
            if (ts < DateTime.Now.TimeOfDay)
            {    
                return textbox;
            }
            return "";
        }

        //allocating more bookable timeslots
        public object TimeSlots(TimeSpan ts)
        {
            string formattedTimespan = ts.ToString("hh\\:mm");
            return formattedTimespan;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Close();
            m.Show();
        }
        public object OverlapBookingCheck(TimeSpan ts)
        {
            if (ts < DateTime.Now.TimeOfDay)
            {
                return "";
            }
            return "Overlaps with another booking";
        }
        /// <summary>
        /// These methods represent individual sessions which the user can book by clicking on any of the buttons. Each session is also assigned a time slot 
        /// which will indicate whether or not the session is active based on the time zone. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button1Click = true;


            MessageBox.Show("Successfully booked!");
            TimeSpan ts2 = new TimeSpan(10, 30, 0);
            TimeSpan ts3 = new TimeSpan(10, 30, 0);
            db.UpdateSessionStatus("Swim Lane 1");

            classListBox2.Items.Add(OverlapBookingCheck(ts2));
            classListBox3.Items.Add(OverlapBookingCheck(ts3));

        }
        //fixing UI layout for sessions page
        private void button2_Click(object sender, EventArgs e)
        {
            button2Click = true;
            DataAccess db = new DataAccess();
            db.UpdateSessionStatus("Swim Lane 2");

            MessageBox.Show("Successfully booked!");
            TimeSpan ts1 = new TimeSpan(10, 30, 0);
            TimeSpan ts3 = new TimeSpan(10, 30, 0);

            classListBox1.Items.Add(OverlapBookingCheck(ts1));
            classListBox3.Items.Add(OverlapBookingCheck(ts3));

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button6Click = true;
            // db.ButtonCheckForeachSession(button6Click, "Swim Lane 1: Pool @ Fitness & Wellbeing");
            //actually button 6
            db.UpdateSessionStatus("Swim Lane 1: Pool");
            MessageBox.Show("Successfully booked!");
            TimeSpan ts7 = new TimeSpan(10, 30, 0);
            TimeSpan ts8 = new TimeSpan(10, 30, 0);

            classListBox7.Items.Add(OverlapBookingCheck(ts7));
            classListBox8.Items.Add(OverlapBookingCheck(ts8));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button7Click = true;
            //actually button 7
            db.UpdateSessionStatus("Swim Lane 2: Pool");
            // db.ButtonCheckForeachSession(button7Click, "Swim Lane 2: Pool @ Fitness & Wellbeing");
            MessageBox.Show("Successfully booked!");
            TimeSpan ts6 = new TimeSpan(10, 30, 0);
            TimeSpan ts8 = new TimeSpan(10, 30, 0);

            classListBox6.Items.Add(OverlapBookingCheck(ts6));
            classListBox8.Items.Add(OverlapBookingCheck(ts8));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button8Click = true;
            //actually button 8
            db.UpdateSessionStatus("Swim Lane 3: Pool");
            MessageBox.Show("Successfully booked!");
            TimeSpan ts6 = new TimeSpan(10, 30, 0);
            TimeSpan ts7 = new TimeSpan(10, 30, 0);

            classListBox6.Items.Add(OverlapBookingCheck(ts6));
            classListBox7.Items.Add(OverlapBookingCheck(ts7));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button11Click = true;
            db.UpdateSessionStatus("Swim Lane 1: Pool");
            MessageBox.Show("Successfully booked!");
            TimeSpan ts12 = new TimeSpan(10, 30, 0);
            TimeSpan ts13 = new TimeSpan(10, 30, 0);

            classListBox12.Items.Add(OverlapBookingCheck(ts12));
            classListBox13.Items.Add(OverlapBookingCheck(ts13));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button12Click = true;
            db.UpdateSessionStatus("Swim Lane 2: Pool");
            MessageBox.Show("Successfully booked!");
            TimeSpan ts11 = new TimeSpan(10, 30, 0);
            TimeSpan ts13 = new TimeSpan(10, 30, 0);

            classListBox11.Items.Add(OverlapBookingCheck(ts11));
            classListBox13.Items.Add(OverlapBookingCheck(ts13));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button13Click = true;
            db.UpdateSessionStatus("Swim Lane 3: Pool");
            MessageBox.Show("Successfully booked!");
            TimeSpan ts11 = new TimeSpan(10, 30, 0);
            TimeSpan ts12 = new TimeSpan(10, 30, 0);

            classListBox11.Items.Add(OverlapBookingCheck(ts11));
            classListBox12.Items.Add(OverlapBookingCheck(ts12));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button3Click = true;
            MessageBox.Show("Successfully booked!");
            // db.ButtonCheckForeachSession(button3Click, "Swim Lane 3");
            db.UpdateSessionStatus("Swim Lane 3");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button4Click = true;
            MessageBox.Show("Successfully booked!");
            //   db.ButtonCheckForeachSession(button4Click, "GRIT Strength: Studio 3 @ Fitness & Wellbeing");
            db.UpdateSessionStatus("GRIT Strength: Studio 3");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button5Click = true;
            MessageBox.Show("Successfully booked!");
            //  db.ButtonCheckForeachSession(button5Click, "Cycle: Studio 2 @ Fitness & Wellbeing");
            db.UpdateSessionStatus("Cycle: Studio 2");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            button9Click = true;
            MessageBox.Show("Successfully booked!");
            db.UpdateSessionStatus("BODYATTACK: Studio 1");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            MessageBox.Show("Successfully booked!");
            db.UpdateSessionStatus("Total Abs: Studio 3");
            button10Click = true;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            MessageBox.Show("Successfully booked!");
            db.UpdateSessionStatus("Boot Camp: Studio 1");
            button14Click = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16Click = true;
            DataAccess db = new DataAccess();
            //   db.UpdateSessionStatus("None"); 

        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17Click = true;
            DataAccess db = new DataAccess();
            //   db.UpdateSessionStatus("None");


        }
        //Pulls side panel  
        private void button16_Click_1(object sender, EventArgs e)
        {
            if (sliderPanel.Height == 531 && sliderPanel.Width == 199)
            {

                sliderPanel.Height = 531;
                sliderPanel.Width = 10;
            }
            else
            {
                sliderPanel.Height = 531;
                sliderPanel.Width = 199;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
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
            sliderPanel.Height = 531;
            sliderPanel.Width = 199;
            sliderPanel.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (sliderPanel.Height == 531 && sliderPanel.Width == 199)
            {

                sliderPanel.Height = 531;
                sliderPanel.Width = 1;
                sliderPanel.Hide();

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click_1(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void GetSessionInfoAAndValidation()
        {
            TimeSpan ts1 = new TimeSpan(10, 30, 0);
            classListBox1.Items.Add(TimeSlots(ts1) + " - " + "11:00");
            classListBox1.Items.Add("Swim Lane 1: Pool @ Fitworks");

            TimeSpan ts2 = new TimeSpan(10, 30, 0);
            classListBox2.Items.Add(TimeSlots(ts2) + " - " + "11:00");
            classListBox2.Items.Add("Swim Lane 2: Pool @ Fitworks");

            TimeSpan ts3 = new TimeSpan(10, 30, 0);
            classListBox3.Items.Add(TimeSlots(ts3) + " - " + "11:00");
            classListBox3.Items.Add("Swim Lane 3: Pool @ Fitworks");

            TimeSpan ts4 = new TimeSpan(12, 30, 0);
            classListBox4.Items.Add(TimeSlots(ts4) + " - " + "13:30");
            classListBox4.Items.Add("GRIT Strength @ Fitworks");
            classListBox4.Items.Add("Studio 1");

            TimeSpan ts5 = new TimeSpan(14, 0, 0);
            classListBox5.Items.Add(TimeSlots(ts5) + " - " + "15:00");
            classListBox5.Items.Add("Cycle @ Fitworks");
            classListBox5.Items.Add("Studio 2");

            TimeSpan ts6 = new TimeSpan(14, 0, 0);
            classListBox6.Items.Add(TimeSlots(ts6) + " - " + "14:30");
            classListBox6.Items.Add("Swim Lane 1: Pool @ Fitworks");

            TimeSpan ts7 = new TimeSpan(14, 0, 0);
            classListBox7.Items.Add(TimeSlots(ts7) + " - " + "14:30");
            classListBox7.Items.Add("Swim Lane 2: Pool @ Fitworks");

            TimeSpan ts8 = new TimeSpan(14, 0, 0);
            classListBox8.Items.Add(TimeSlots(ts8) + " - " + "14:30");
            classListBox8.Items.Add("Swim Lane 3: Pool @ Fitworks");

            TimeSpan ts9 = new TimeSpan(16, 30, 0);
            classListBox9.Items.Add(TimeSlots(ts9) + " - " + "17:30");
            classListBox9.Items.Add("BODYATTACK @ Fitworks");
            classListBox9.Items.Add("Studio 1");

            TimeSpan ts10 = new TimeSpan(18, 30, 0);
            classListBox10.Items.Add(TimeSlots(ts10) + " - " + "19:30");
            classListBox10.Items.Add("Total Abs @ Fitworks");
            classListBox10.Items.Add("Studio 3");

            TimeSpan ts11 = new TimeSpan(20, 00, 0);
            classListBox11.Items.Add(TimeSlots(ts11) + " - " + "20:30");
            classListBox11.Items.Add("Swim Lane 1: Pool @ Fitworks");

            TimeSpan ts12 = new TimeSpan(20, 00, 0);
            classListBox12.Items.Add(TimeSlots(ts12) + " - " + "20:30");
            classListBox12.Items.Add("Swim Lane 2: Pool @ Fitworks");

            TimeSpan ts13 = new TimeSpan(20, 00, 0);
            classListBox13.Items.Add(TimeSlots(ts13) + " - " + "20:30");
            classListBox13.Items.Add("Swim Lane 3: Pool @ Fitworks");

            TimeSpan ts14 = new TimeSpan(20, 30, 0);
            classListBox14.Items.Add(TimeSlots(ts14) + " - " + "21:00");
            classListBox14.Items.Add("Boot Camp @ Fitworks");
            classListBox14.Items.Add("Studio 2");
            //button1.Enabled = false; 

            if (IsExpiredSlot(ts1, textBox1.Text) == textBox1.Text)
            {
                classListBox1.Items.Add(IsExpiredSlot(ts1, textBox1.Text));
                classButton1.BackColor = Color.FromArgb(154, 156, 155);
                classButton1.ForeColor = Color.White;
                classButton1.Enabled = false;
                classListBox1.Items.RemoveAt(2);
                textBox1.Show();

            }
            if (IsExpiredSlot(ts2, textBox2.Text) == textBox2.Text)
            {
                classListBox2.Items.Add(IsExpiredSlot(ts2, textBox2.Text));
                classButton2.BackColor = Color.FromArgb(154, 156, 155);
                classButton2.ForeColor = Color.White;
                classButton2.Enabled = false;
                classListBox2.Items.RemoveAt(2);
                textBox2.Show();

            }
            if (IsExpiredSlot(ts3, textBox3.Text) == textBox3.Text)
            {
                classListBox3.Items.Add(IsExpiredSlot(ts3, textBox3.Text));
                classButton3.BackColor = Color.FromArgb(154, 156, 155);
                classButton3.ForeColor = Color.White;
                classButton3.Enabled = false;
                classListBox3.Items.RemoveAt(2);
                textBox3.Show();

            }
            if (IsExpiredSlot(ts4, textBox4.Text) == textBox4.Text)
            {
                classListBox4.Items.Add(IsExpiredSlot(ts4, textBox4.Text));
                classButton4.BackColor = Color.FromArgb(154, 156, 155);
                classButton4.ForeColor = Color.White;
                classButton4.Enabled = false;
                classListBox4.Items.RemoveAt(2);
                textBox4.Show();

            }
            if (IsExpiredSlot(ts5, textBox5.Text) == textBox5.Text)
            {
                classListBox5.Items.Add(IsExpiredSlot(ts5, textBox5.Text));
                classButton5.BackColor = Color.FromArgb(154, 156, 155);
                classButton5.ForeColor = Color.White;
                classButton5.Enabled = false;
                classListBox5.Items.RemoveAt(2);
                textBox5.Show();

            }
            if (IsExpiredSlot(ts6, textBox6.Text) == textBox6.Text)
            {
                classListBox6.Items.Add(IsExpiredSlot(ts6, textBox6.Text));
                classButton6.BackColor = Color.FromArgb(154, 156, 155);
                classButton6.ForeColor = Color.White;
                classButton6.Enabled = false;
                classListBox6.Items.RemoveAt(2);
                textBox6.Show();

            }
            if (IsExpiredSlot(ts7, textBox7.Text) == textBox7.Text)
            {
                classListBox7.Items.Add(IsExpiredSlot(ts7, textBox7.Text));
                classButton7.BackColor = Color.FromArgb(154, 156, 155);
                classButton7.ForeColor = Color.White;
                classButton7.Enabled = false;
                classListBox7.Items.RemoveAt(2);
                textBox7.Show();
            }
            if (IsExpiredSlot(ts8, textBox8.Text) == textBox8.Text)
            {
                classListBox8.Items.Add(IsExpiredSlot(ts8, textBox8.Text));
                classButton8.BackColor = Color.FromArgb(154, 156, 155);
                classButton8.ForeColor = Color.White;
                classButton8.Enabled = false;
                classListBox8.Items.RemoveAt(2);
                textBox8.Show();

            }
            if (IsExpiredSlot(ts9, textBox9.Text) == textBox9.Text)
            {
                classListBox9.Items.Add(IsExpiredSlot(ts9, textBox9.Text));
                classButton9.BackColor = Color.FromArgb(154, 156, 155);
                classButton9.ForeColor = Color.White;
                classButton9.Enabled = false;
                classListBox9.Items.RemoveAt(2);
                textBox9.Show();

            }
            if (IsExpiredSlot(ts10, textBox10.Text) == textBox10.Text)
            {
                classListBox10.Items.Add(IsExpiredSlot(ts10, textBox10.Text));
                classButton10.BackColor = Color.FromArgb(154, 156, 155);
                classButton10.ForeColor = Color.White;
                classButton10.Enabled = false;
                classListBox10.Items.RemoveAt(2);
                textBox10.Show();

            }
            if (IsExpiredSlot(ts11, textBox11.Text) == textBox11.Text)
            {
                classListBox11.Items.Add(IsExpiredSlot(ts11, textBox11.Text));
                classButton11.BackColor = Color.FromArgb(154, 156, 155);
                classButton11.ForeColor = Color.White;
                classButton11.Enabled = false;
                classListBox11.Items.RemoveAt(2);
                textBox11.Show();

            }
            if (IsExpiredSlot(ts12, textBox12.Text) == textBox12.Text)
            {
                classListBox12.Items.Add(IsExpiredSlot(ts12, textBox12.Text));
                classButton12.BackColor = Color.FromArgb(154, 156, 155);
                classButton12.ForeColor = Color.White;
                classButton12.Enabled = false;
                classListBox12.Items.RemoveAt(2);
                textBox12.Show();

            }
            if (IsExpiredSlot(ts13, textBox13.Text) == textBox13.Text)
            {
                classListBox13.Items.Add(IsExpiredSlot(ts13, textBox13.Text));
                classButton13.BackColor = Color.FromArgb(154, 156, 155);
                classButton13.ForeColor = Color.White;
                classButton13.Enabled = false;
                classListBox13.Items.RemoveAt(2);
                textBox13.Show();

            }
            if (IsExpiredSlot(ts14, textBox14.Text) == textBox14.Text)
            {
                classListBox14.Items.Add(IsExpiredSlot(ts14, textBox14.Text));
                classButton14.BackColor = Color.FromArgb(154, 156, 155);
                classButton14.ForeColor = Color.White;
                classButton14.Enabled = false;
                classListBox14.Items.RemoveAt(2);
                textBox14.Show();

            }
        }


        public bool button1Click = false;
        public bool button2Click = false;
        public static bool button3Click = false;
        public static bool button4Click = false;
        public static bool button5Click = false;
        public static bool button6Click = false;
        public static bool button7Click = false;
        public static bool button8Click = false;
        public static bool button9Click = false;
        public static bool button10Click = false;
        public static bool button11Click = false;
        public static bool button12Click = false;
        public static bool button13Click = false;
        public static bool button14Click = false;
        public static bool button16Click = false;
        public static bool button17Click = false;
    }
        

}
