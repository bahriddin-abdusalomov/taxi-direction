namespace Taxi.Desktop.Forms
{
    partial class AllForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllForm));
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            exit = new Button();
            history = new Button();
            service = new Button();
            myProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-273, -35);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(898, 350);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(155, 463);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(77, 64);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(155, 380);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(155, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // exit
            // 
            exit.BackColor = Color.Red;
            exit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            exit.Location = new Point(238, 463);
            exit.Name = "exit";
            exit.Size = new Size(264, 64);
            exit.TabIndex = 12;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            // 
            // history
            // 
            history.BackColor = Color.Lime;
            history.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            history.Location = new Point(238, 380);
            history.Name = "history";
            history.Size = new Size(264, 64);
            history.TabIndex = 11;
            history.Text = "History";
            history.UseVisualStyleBackColor = false;
            // 
            // service
            // 
            service.BackColor = Color.Yellow;
            service.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            service.Location = new Point(238, 298);
            service.Name = "service";
            service.Size = new Size(264, 64);
            service.TabIndex = 10;
            service.Text = "Taxi service";
            service.UseVisualStyleBackColor = false;
            service.Click += service_Click;
            // 
            // myProfile
            // 
            myProfile.BackColor = Color.FromArgb(192, 192, 255);
            myProfile.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            myProfile.Location = new Point(238, 213);
            myProfile.Name = "myProfile";
            myProfile.Size = new Size(264, 64);
            myProfile.TabIndex = 9;
            myProfile.Text = "My profile";
            myProfile.UseVisualStyleBackColor = false;
            myProfile.Click += myProfile_Click;
            // 
            // AllForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(580, 570);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exit);
            Controls.Add(history);
            Controls.Add(service);
            Controls.Add(myProfile);
            Controls.Add(pictureBox5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AllForm";
            Text = "All Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button exit;
        private Button history;
        private Button service;
        private Button myProfile;
    }
}