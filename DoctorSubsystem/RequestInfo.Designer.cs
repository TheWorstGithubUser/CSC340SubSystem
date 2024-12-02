
namespace DoctorSubsystem_VS
{
    partial class RequestInfo
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.reqLabel = new System.Windows.Forms.Label();
            this.descripBox = new System.Windows.Forms.TextBox();
            this.descripLabel = new System.Windows.Forms.Label();
            this.statusDropdown = new System.Windows.Forms.ComboBox();
            this.updateStatusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(92, 17);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Last Modified";
            // 
            // reqLabel
            // 
            this.reqLabel.AutoSize = true;
            this.reqLabel.Location = new System.Drawing.Point(12, 46);
            this.reqLabel.Name = "reqLabel";
            this.reqLabel.Size = new System.Drawing.Size(61, 17);
            this.reqLabel.TabIndex = 1;
            this.reqLabel.Text = "Request";
            // 
            // descripBox
            // 
            this.descripBox.Location = new System.Drawing.Point(12, 101);
            this.descripBox.Multiline = true;
            this.descripBox.Name = "descripBox";
            this.descripBox.ReadOnly = true;
            this.descripBox.Size = new System.Drawing.Size(370, 236);
            this.descripBox.TabIndex = 2;
            // 
            // descripLabel
            // 
            this.descripLabel.AutoSize = true;
            this.descripLabel.Location = new System.Drawing.Point(12, 81);
            this.descripLabel.Name = "descripLabel";
            this.descripLabel.Size = new System.Drawing.Size(79, 17);
            this.descripLabel.TabIndex = 3;
            this.descripLabel.Text = "Description";
            // 
            // statusDropdown
            // 
            this.statusDropdown.FormattingEnabled = true;
            this.statusDropdown.Items.AddRange(new object[] {
            "Undecided",
            "Approved",
            "Denied"});
            this.statusDropdown.Location = new System.Drawing.Point(262, 46);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(120, 24);
            this.statusDropdown.TabIndex = 4;
            this.statusDropdown.SelectedIndexChanged += new System.EventHandler(this.statusDropdown_SelectedIndexChanged);
            // 
            // updateStatusButton
            // 
            this.updateStatusButton.Enabled = false;
            this.updateStatusButton.Location = new System.Drawing.Point(262, 367);
            this.updateStatusButton.Name = "updateStatusButton";
            this.updateStatusButton.Size = new System.Drawing.Size(120, 41);
            this.updateStatusButton.TabIndex = 5;
            this.updateStatusButton.Text = "Update Status";
            this.updateStatusButton.UseVisualStyleBackColor = true;
            this.updateStatusButton.Click += new System.EventHandler(this.updateStatusButton_Click);
            // 
            // RequestInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.updateStatusButton);
            this.Controls.Add(this.statusDropdown);
            this.Controls.Add(this.descripLabel);
            this.Controls.Add(this.descripBox);
            this.Controls.Add(this.reqLabel);
            this.Controls.Add(this.dateLabel);
            this.Name = "RequestInfo";
            this.Text = "RequestInfo";
            this.Load += new System.EventHandler(this.RequestInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label reqLabel;
        private System.Windows.Forms.TextBox descripBox;
        private System.Windows.Forms.Label descripLabel;
        private System.Windows.Forms.ComboBox statusDropdown;
        private System.Windows.Forms.Button updateStatusButton;
    }
}