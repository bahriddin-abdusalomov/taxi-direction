namespace Taxi.Desktop.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            pictureBox1 = new PictureBox();
            labelFirstName = new Label();
            buttonEdit = new Button();
            checkBoxPassword = new CheckBox();
            label6 = new Label();
            textBoxPassword = new TextBox();
            label7 = new Label();
            textBoxUserName = new TextBox();
            label5 = new Label();
            textBoxLastName = new TextBox();
            label4 = new Label();
            textBoxFirstName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFirstName.Location = new Point(41, 168);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(75, 20);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "full name";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Cyan;
            buttonEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.Location = new Point(41, 231);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(141, 32);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "edit profile";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // checkBoxPassword
            // 
            checkBoxPassword.AutoSize = true;
            checkBoxPassword.BackColor = Color.White;
            checkBoxPassword.Location = new Point(581, 239);
            checkBoxPassword.Name = "checkBoxPassword";
            checkBoxPassword.Size = new Size(65, 24);
            checkBoxPassword.TabIndex = 23;
            checkBoxPassword.Text = "show";
            checkBoxPassword.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(295, 214);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 22;
            label6.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(296, 237);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(350, 27);
            textBoxPassword.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(295, 157);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 20;
            label7.Text = "User name";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(296, 180);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(350, 27);
            textBoxUserName.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(295, 100);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 18;
            label5.Text = "Last name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(296, 123);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(350, 27);
            textBoxLastName.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(295, 43);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 16;
            label4.Text = "First name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(296, 66);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(350, 27);
            textBoxFirstName.TabIndex = 15;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(744, 335);
            Controls.Add(checkBoxPassword);
            Controls.Add(label6);
            Controls.Add(textBoxPassword);
            Controls.Add(label7);
            Controls.Add(textBoxUserName);
            Controls.Add(label5);
            Controls.Add(textBoxLastName);
            Controls.Add(label4);
            Controls.Add(textBoxFirstName);
            Controls.Add(buttonEdit);
            Controls.Add(labelFirstName);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfileForm";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelFirstName;
        private Button buttonEdit;
        private CheckBox checkBoxPassword;
        private Label label6;
        private TextBox textBoxPassword;
        private Label label7;
        private TextBox textBoxUserName;
        private Label label5;
        private TextBox textBoxLastName;
        private Label label4;
        private TextBox textBoxFirstName;
    }
}