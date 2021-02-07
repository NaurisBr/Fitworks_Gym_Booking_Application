namespace FitworksApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.passwordLoginTextBox = new System.Windows.Forms.TextBox();
            this.emailLogin_textbox = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.forgetPasswordLabel = new System.Windows.Forms.Label();
            this.userAccountDatabaseDataSet1 = new FitworksApp.UserAccountDatabaseDataSet();
            this.userAccountDatabaseDataSet2 = new FitworksApp.UserAccountDatabaseDataSet();
            this.loginBackgroundImage = new System.Windows.Forms.PictureBox();
            this.LogInButtonX = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton1 = new FitworksApp.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBackgroundImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLoginTextBox
            // 
            this.passwordLoginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLoginTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordLoginTextBox.Location = new System.Drawing.Point(67, 205);
            this.passwordLoginTextBox.Multiline = true;
            this.passwordLoginTextBox.Name = "passwordLoginTextBox";
            this.passwordLoginTextBox.PasswordChar = '*';
            this.passwordLoginTextBox.Size = new System.Drawing.Size(266, 31);
            this.passwordLoginTextBox.TabIndex = 12;
            this.passwordLoginTextBox.Text = "Password";
            this.passwordLoginTextBox.TextChanged += new System.EventHandler(this.PasswordLogin_textbox);
            this.passwordLoginTextBox.Enter += new System.EventHandler(this.textBox5_Enter);
            this.passwordLoginTextBox.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // emailLogin_textbox
            // 
            this.emailLogin_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLogin_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailLogin_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLogin_textbox.ForeColor = System.Drawing.Color.Black;
            this.emailLogin_textbox.Location = new System.Drawing.Point(67, 165);
            this.emailLogin_textbox.Multiline = true;
            this.emailLogin_textbox.Name = "emailLogin_textbox";
            this.emailLogin_textbox.Size = new System.Drawing.Size(266, 29);
            this.emailLogin_textbox.TabIndex = 11;
            this.emailLogin_textbox.Text = "Email";
            this.emailLogin_textbox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.emailLogin_textbox.Enter += new System.EventHandler(this.emailLogin_textbox_Enter);
            this.emailLogin_textbox.Leave += new System.EventHandler(this.emailLogin_textbox_Leave);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.AutoSize = true;
            this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.White;
            this.logo.Location = new System.Drawing.Point(81, 53);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 72);
            this.logo.TabIndex = 15;
            this.logo.Text = "Fitworks";
            this.logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(74, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Shortcut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(235)))));
            this.registerButton.Location = new System.Drawing.Point(99, 340);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(230, 37);
            this.registerButton.TabIndex = 17;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(31, 165);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 204);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // forgetPasswordLabel
            // 
            this.forgetPasswordLabel.AutoSize = true;
            this.forgetPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(235)))));
            this.forgetPasswordLabel.Location = new System.Drawing.Point(142, 249);
            this.forgetPasswordLabel.Name = "forgetPasswordLabel";
            this.forgetPasswordLabel.Size = new System.Drawing.Size(122, 17);
            this.forgetPasswordLabel.TabIndex = 31;
            this.forgetPasswordLabel.Text = "Forget Password?";
            // 
            // userAccountDatabaseDataSet1
            // 
            this.userAccountDatabaseDataSet1.DataSetName = "UserAccountDatabaseDataSet";
            this.userAccountDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userAccountDatabaseDataSet2
            // 
            this.userAccountDatabaseDataSet2.DataSetName = "UserAccountDatabaseDataSet";
            this.userAccountDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBackgroundImage
            // 
            this.loginBackgroundImage.Image = ((System.Drawing.Image)(resources.GetObject("loginBackgroundImage.Image")));
            this.loginBackgroundImage.Location = new System.Drawing.Point(-26, -1);
            this.loginBackgroundImage.Name = "loginBackgroundImage";
            this.loginBackgroundImage.Size = new System.Drawing.Size(424, 632);
            this.loginBackgroundImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginBackgroundImage.TabIndex = 19;
            this.loginBackgroundImage.TabStop = false;
            this.loginBackgroundImage.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // LogInButtonX
            // 
            this.LogInButtonX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogInButtonX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(235)))));
            this.LogInButtonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButtonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButtonX.ForeColor = System.Drawing.Color.White;
            this.LogInButtonX.Location = new System.Drawing.Point(74, 292);
            this.LogInButtonX.Name = "LogInButtonX";
            this.LogInButtonX.Size = new System.Drawing.Size(230, 37);
            this.LogInButtonX.TabIndex = 34;
            this.LogInButtonX.Text = "Log In";
            this.LogInButtonX.UseVisualStyleBackColor = false;
            this.LogInButtonX.Click += new System.EventHandler(this.LogInButtonX_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(70, 532);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(235)))));
            this.button3.Location = new System.Drawing.Point(65, 525);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(258, 42);
            this.button3.TabIndex = 59;
            this.button3.Text = "Log in with Facebook";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_3);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(71, 483);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(235)))));
            this.button4.Location = new System.Drawing.Point(65, 473);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 42);
            this.button4.TabIndex = 57;
            this.button4.Text = "Log In with Google";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(235)))));
            this.label3.Location = new System.Drawing.Point(178, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Or";
            // 
            // LoginButton1
            // 
            this.LoginButton1.Angle = 57F;
            this.LoginButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginButton1.BorderRadius = 20;
            this.LoginButton1.Color0 = System.Drawing.Color.Cyan;
            this.LoginButton1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(235)))));
            this.LoginButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton1.ForeColor = System.Drawing.Color.White;
            this.LoginButton1.Location = new System.Drawing.Point(106, 566);
            this.LoginButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoginButton1.Name = "LoginButton1";
            this.LoginButton1.Size = new System.Drawing.Size(178, 41);
            this.LoginButton1.TabIndex = 32;
            this.LoginButton1.Visible = false;
            this.LoginButton1.Load += new System.EventHandler(this.LoginButton1_Load);
            this.LoginButton1.Click += new System.EventHandler(this.LoginButton1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 633);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.LogInButtonX);
            this.Controls.Add(this.LoginButton1);
            this.Controls.Add(this.forgetPasswordLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.passwordLoginTextBox);
            this.Controls.Add(this.emailLogin_textbox);
            this.Controls.Add(this.loginBackgroundImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBackgroundImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordLoginTextBox;
        private System.Windows.Forms.TextBox emailLogin_textbox;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label forgetPasswordLabel;
        private UserAccountDatabaseDataSet userAccountDatabaseDataSet1;
        private UserAccountDatabaseDataSet userAccountDatabaseDataSet2;
        private CustomButton LoginButton1;
        private System.Windows.Forms.PictureBox loginBackgroundImage;
        private System.Windows.Forms.Button LogInButtonX;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
    }
}

