namespace Taxi.Desktop.Forms
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            textBoxAllHistory = new TextBox();
            buttonGet = new Button();
            SuspendLayout();
            // 
            // textBoxAllHistory
            // 
            textBoxAllHistory.Location = new Point(46, 29);
            textBoxAllHistory.Multiline = true;
            textBoxAllHistory.Name = "textBoxAllHistory";
            textBoxAllHistory.Size = new Size(719, 358);
            textBoxAllHistory.TabIndex = 0;
            // 
            // buttonGet
            // 
            buttonGet.BackColor = Color.Cyan;
            buttonGet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGet.Location = new Point(594, 402);
            buttonGet.Name = "buttonGet";
            buttonGet.Size = new Size(171, 36);
            buttonGet.TabIndex = 1;
            buttonGet.Text = "get history";
            buttonGet.UseVisualStyleBackColor = false;
            buttonGet.Click += buttonGet_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGet);
            Controls.Add(textBoxAllHistory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HistoryForm";
            Text = "History";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAllHistory;
        private Button buttonGet;
    }
}