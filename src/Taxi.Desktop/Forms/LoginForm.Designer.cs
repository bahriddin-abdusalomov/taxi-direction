namespace Taxi.Desktop.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            checkBoxPassword = new CheckBox();
            buttonSignUp = new Button();
            buttonSignIn = new Button();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelUserName = new Label();
            textBoxUserName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.BackColor = Color.White;
            checkBoxPassword.Location = new Point(712, 243);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(65, 24);
            checkBoxPassword.TabIndex = 29;
            checkBoxPassword.Text = "show";
            checkBoxPassword.UseVisualStyleBackColor = false;
            checkBoxPassword.CheckedChanged += checkBoxPassword_CheckedChanged;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.FromArgb(128, 128, 255);
            buttonSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(626, 302);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(151, 35);
            buttonSignUp.TabIndex = 28;
            buttonSignUp.Text = "sign up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.FromArgb(128, 128, 255);
            buttonSignIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignIn.Location = new Point(427, 302);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(151, 35);
            buttonSignIn.TabIndex = 27;
            buttonSignIn.Text = "sign in";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(426, 218);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(76, 20);
            labelPassword.TabIndex = 26;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(427, 241);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(350, 27);
            textBoxPassword.TabIndex = 25;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.Location = new Point(426, 161);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(84, 20);
            labelUserName.TabIndex = 24;
            labelUserName.Text = "User name";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(427, 184);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(350, 27);
            textBoxUserName.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 398);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(442, 37);
            label1.Name = "label1";
            label1.Size = new Size(346, 50);
            label1.TabIndex = 16;
            label1.Text = "Welcome Taxi App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 87);
            label2.Name = "label2";
            label2.Size = new Size(216, 20);
            label2.TabIndex = 17;
            label2.Text = "thank you for using our services";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(809, 450);
            Controls.Add(checkBoxPassword);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonSignIn);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelUserName);
            Controls.Add(textBoxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxPassword;
        private Button buttonSignUp;
        private Button buttonSignIn;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelUserName;
        private TextBox textBoxUserName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}