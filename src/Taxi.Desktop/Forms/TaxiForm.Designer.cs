namespace Taxi.Desktop.Forms
{
    partial class TaxiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxiForm));
            pictureBox1 = new PictureBox();
            labelPassword = new Label();
            textBoxDestination = new TextBox();
            labelUserName = new Label();
            textBoxFrom = new TextBox();
            label1 = new Label();
            textBoxDistance = new TextBox();
            labelTime = new Label();
            labelSpeed = new Label();
            labelStartTime = new Label();
            labelEndTime = new Label();
            buttonStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-51, -34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(417, 114);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(90, 20);
            labelPassword.TabIndex = 33;
            labelPassword.Text = "Destination";
            // 
            // textBoxDestination
            // 
            textBoxDestination.Location = new Point(418, 137);
            textBoxDestination.Name = "textBoxDestination";
            textBoxDestination.Size = new Size(350, 27);
            textBoxDestination.TabIndex = 32;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUserName.Location = new Point(417, 57);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(46, 20);
            labelUserName.TabIndex = 31;
            labelUserName.Text = "From";
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(418, 80);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(350, 27);
            textBoxFrom.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(417, 176);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 35;
            label1.Text = "Distance /km";
            label1.Click += label1_Click;
            // 
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(418, 199);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.Size = new Size(350, 27);
            textBoxDistance.TabIndex = 34;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.Location = new Point(410, 355);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(89, 20);
            labelTime.TabIndex = 36;
            labelTime.Text = "Time to go:";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSpeed.Location = new Point(410, 387);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(116, 20);
            labelSpeed.TabIndex = 37;
            labelSpeed.Text = "Average speed:";
            // 
            // labelStartTime
            // 
            labelStartTime.AutoSize = true;
            labelStartTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStartTime.Location = new Point(410, 277);
            labelStartTime.Name = "labelStartTime";
            labelStartTime.Size = new Size(83, 20);
            labelStartTime.TabIndex = 38;
            labelStartTime.Text = "Start time:";
            // 
            // labelEndTime
            // 
            labelEndTime.AutoSize = true;
            labelEndTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEndTime.Location = new Point(410, 315);
            labelEndTime.Name = "labelEndTime";
            labelEndTime.Size = new Size(75, 20);
            labelEndTime.TabIndex = 39;
            labelEndTime.Text = "End time:";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.Yellow;
            buttonStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.Location = new Point(618, 246);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(150, 29);
            buttonStart.TabIndex = 40;
            buttonStart.Text = "start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // TaxiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(798, 439);
            Controls.Add(buttonStart);
            Controls.Add(labelEndTime);
            Controls.Add(labelStartTime);
            Controls.Add(labelSpeed);
            Controls.Add(labelTime);
            Controls.Add(label1);
            Controls.Add(textBoxDistance);
            Controls.Add(labelPassword);
            Controls.Add(textBoxDestination);
            Controls.Add(labelUserName);
            Controls.Add(textBoxFrom);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TaxiForm";
            Text = "Taxi";
            Load += TaxiForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelPassword;
        private TextBox textBoxDestination;
        private Label labelUserName;
        private TextBox textBoxFrom;
        private Label label1;
        private TextBox textBoxDistance;
        private Label labelTime;
        private Label labelSpeed;
        private Label labelStartTime;
        private Label labelEndTime;
        private Button buttonStart;
    }
}