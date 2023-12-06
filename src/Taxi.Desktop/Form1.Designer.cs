namespace Taxi.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxFirstName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxLastName = new TextBox();
            label6 = new Label();
            textBoxPassword = new TextBox();
            label7 = new Label();
            textBoxUserName = new TextBox();
            button1 = new Button();
            buttonSignUp = new Button();
            checkBoxPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(450, 53);
            label1.Name = "label1";
            label1.Size = new Size(345, 50);
            label1.TabIndex = 1;
            label1.Text = "Create An Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 103);
            label2.Name = "label2";
            label2.Size = new Size(286, 20);
            label2.TabIndex = 2;
            label2.Text = "Create an account to enjoy all the services";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(545, 123);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 3;
            label3.Text = "without any ads for free!";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(455, 184);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(350, 27);
            textBoxFirstName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(454, 161);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 5;
            label4.Text = "First name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(454, 218);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 7;
            label5.Text = "Last name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(455, 241);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(350, 27);
            textBoxLastName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(454, 332);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 11;
            label6.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(455, 355);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(350, 27);
            textBoxPassword.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(454, 275);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 9;
            label7.Text = "User name";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(455, 298);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(350, 27);
            textBoxUserName.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(455, 416);
            button1.Name = "button1";
            button1.Size = new Size(151, 35);
            button1.TabIndex = 12;
            button1.Text = "sign in";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.FromArgb(128, 128, 255);
            buttonSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(654, 416);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(151, 35);
            buttonSignUp.TabIndex = 13;
            buttonSignUp.Text = "sign up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.BackColor = Color.White;
            checkBoxPassword.Location = new Point(740, 357);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(65, 24);
            checkBoxPassword.TabIndex = 14;
            checkBoxPassword.Text = "show";
            checkBoxPassword.UseVisualStyleBackColor = false;
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(844, 505);
            Controls.Add(checkBoxPassword);
            Controls.Add(buttonSignUp);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(textBoxPassword);
            Controls.Add(label7);
            Controls.Add(textBoxUserName);
            Controls.Add(label5);
            Controls.Add(textBoxLastName);
            Controls.Add(label4);
            Controls.Add(textBoxFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFirstName;
        private Label label4;
        private Label label5;
        private TextBox textBoxLastName;
        private Label label6;
        private TextBox textBoxPassword;
        private Label label7;
        private TextBox textBoxUserName;
        private Button button1;
        private Button buttonSignUp;
        private CheckBox checkBoxPassword;
    }
}