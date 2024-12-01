namespace PatientSubsystem
{
    partial class NotificationForm
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
            this.NotifTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // NotifTextBox
            // 
            this.NotifTextBox.Location = new System.Drawing.Point(39, 12);
            this.NotifTextBox.Name = "NotifTextBox";
            this.NotifTextBox.ReadOnly = true;
            this.NotifTextBox.Size = new System.Drawing.Size(687, 436);
            this.NotifTextBox.TabIndex = 0;
            this.NotifTextBox.Text = "";
            this.NotifTextBox.TextChanged += new System.EventHandler(this.NotifTextBox_TextChanged);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotifTextBox);
            this.Name = "NotificationForm";
            this.Text = "NotificationForm";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox NotifTextBox;
    }
}