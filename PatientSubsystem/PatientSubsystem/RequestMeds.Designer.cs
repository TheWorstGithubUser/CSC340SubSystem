namespace PatientSubsystem
{
    partial class RequestMeds
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
            this.PatientPrescriptionList = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.prescriptionIDTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PatientPrescriptionList
            // 
            this.PatientPrescriptionList.Location = new System.Drawing.Point(264, 65);
            this.PatientPrescriptionList.Name = "PatientPrescriptionList";
            this.PatientPrescriptionList.ReadOnly = true;
            this.PatientPrescriptionList.Size = new System.Drawing.Size(507, 343);
            this.PatientPrescriptionList.TabIndex = 0;
            this.PatientPrescriptionList.Text = "";
            this.PatientPrescriptionList.TextChanged += new System.EventHandler(this.PatientPrescriptionList_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.Location = new System.Drawing.Point(262, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(508, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Your Prescriptions";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.richTextBox1.Location = new System.Drawing.Point(12, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(246, 45);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Enter the name of the medicine you wish to refill";
            // 
            // prescriptionIDTextBox
            // 
            this.prescriptionIDTextBox.Location = new System.Drawing.Point(12, 80);
            this.prescriptionIDTextBox.Name = "prescriptionIDTextBox";
            this.prescriptionIDTextBox.Size = new System.Drawing.Size(246, 22);
            this.prescriptionIDTextBox.TabIndex = 5;
            this.prescriptionIDTextBox.Text = "enter name here";
            this.prescriptionIDTextBox.TextChanged += new System.EventHandler(this.prescriptionIDTextBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Control;
            this.SubmitButton.Location = new System.Drawing.Point(12, 124);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(246, 58);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.Control;
            this.back.Location = new System.Drawing.Point(12, 200);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(246, 58);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // RequestMeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.prescriptionIDTextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PatientPrescriptionList);
            this.Name = "RequestMeds";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.RequestMeds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox PatientPrescriptionList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox prescriptionIDTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button back;
    }
}