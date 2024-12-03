
namespace DoctorSubsystem_VS
{
    partial class RecordItemDetailsForm
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
            this.recordInfoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.refillsTextBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recordInfoLabel
            // 
            this.recordInfoLabel.AutoSize = true;
            this.recordInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.recordInfoLabel.Name = "recordInfoLabel";
            this.recordInfoLabel.Size = new System.Drawing.Size(108, 17);
            this.recordInfoLabel.TabIndex = 0;
            this.recordInfoLabel.Text = "Prescription For";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Refills:";
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Enabled = false;
            this.detailsTextBox.Location = new System.Drawing.Point(101, 42);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(687, 236);
            this.detailsTextBox.TabIndex = 3;
            // 
            // refillsTextBox
            // 
            this.refillsTextBox.Enabled = false;
            this.refillsTextBox.Location = new System.Drawing.Point(101, 284);
            this.refillsTextBox.Name = "refillsTextBox";
            this.refillsTextBox.Size = new System.Drawing.Size(100, 22);
            this.refillsTextBox.TabIndex = 4;
            this.refillsTextBox.Text = "0";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(101, 323);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(152, 44);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit Record";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(259, 323);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(152, 44);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // RecordItemDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.refillsTextBox);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recordInfoLabel);
            this.Name = "RecordItemDetailsForm";
            this.Text = "Record Item Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recordInfoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.TextBox refillsTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button saveButton;
    }
}