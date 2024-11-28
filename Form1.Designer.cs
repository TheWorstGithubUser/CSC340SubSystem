namespace PatientSubsystem
{
    partial class Form1
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
            this.checkRecordsButton = new System.Windows.Forms.Button();
            this.phoneCallRequest = new System.Windows.Forms.Button();
            this.medicineRequest = new System.Windows.Forms.Button();
            this.notificationButton = new System.Windows.Forms.Button();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.requestAppointment = new System.Windows.Forms.Button();
            this.cancelAppointment = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // checkRecordsButton
            // 
            this.checkRecordsButton.Location = new System.Drawing.Point(22, 199);
            this.checkRecordsButton.Name = "checkRecordsButton";
            this.checkRecordsButton.Size = new System.Drawing.Size(219, 26);
            this.checkRecordsButton.TabIndex = 0;
            this.checkRecordsButton.Text = "Check Medical Records";
            this.checkRecordsButton.UseVisualStyleBackColor = true;
            this.checkRecordsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneCallRequest
            // 
            this.phoneCallRequest.Location = new System.Drawing.Point(22, 240);
            this.phoneCallRequest.Name = "phoneCallRequest";
            this.phoneCallRequest.Size = new System.Drawing.Size(219, 24);
            this.phoneCallRequest.TabIndex = 1;
            this.phoneCallRequest.Text = "Request Phone Call From Doctor";
            this.phoneCallRequest.UseVisualStyleBackColor = true;
            this.phoneCallRequest.Click += new System.EventHandler(this.phoneCallRequest_Click);
            // 
            // medicineRequest
            // 
            this.medicineRequest.Location = new System.Drawing.Point(23, 279);
            this.medicineRequest.Name = "medicineRequest";
            this.medicineRequest.Size = new System.Drawing.Size(218, 27);
            this.medicineRequest.TabIndex = 2;
            this.medicineRequest.Text = "Request Medicine";
            this.medicineRequest.UseVisualStyleBackColor = true;
            this.medicineRequest.Click += new System.EventHandler(this.medicineRequest_Click);
            // 
            // notificationButton
            // 
            this.notificationButton.Location = new System.Drawing.Point(22, 321);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(219, 25);
            this.notificationButton.TabIndex = 3;
            this.notificationButton.Text = "Recieved Notifications";
            this.notificationButton.UseVisualStyleBackColor = true;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Location = new System.Drawing.Point(395, 52);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(362, 22);
            this.appointmentDatePicker.TabIndex = 4;
            this.appointmentDatePicker.ValueChanged += new System.EventHandler(this.appointmentDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Request Appointment";
            // 
            // requestAppointment
            // 
            this.requestAppointment.Location = new System.Drawing.Point(397, 80);
            this.requestAppointment.Name = "requestAppointment";
            this.requestAppointment.Size = new System.Drawing.Size(152, 33);
            this.requestAppointment.TabIndex = 6;
            this.requestAppointment.Text = "Request Appointment";
            this.requestAppointment.UseVisualStyleBackColor = true;
            this.requestAppointment.Click += new System.EventHandler(this.requestAppointment_Click);
            // 
            // cancelAppointment
            // 
            this.cancelAppointment.Location = new System.Drawing.Point(594, 80);
            this.cancelAppointment.Name = "cancelAppointment";
            this.cancelAppointment.Size = new System.Drawing.Size(163, 31);
            this.cancelAppointment.TabIndex = 7;
            this.cancelAppointment.Text = "Cancel Appointment";
            this.cancelAppointment.UseVisualStyleBackColor = true;
            this.cancelAppointment.Click += new System.EventHandler(this.cancelAppointment_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(395, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(322, 196);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cancelAppointment);
            this.Controls.Add(this.requestAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.medicineRequest);
            this.Controls.Add(this.phoneCallRequest);
            this.Controls.Add(this.checkRecordsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkRecordsButton;
        private System.Windows.Forms.Button phoneCallRequest;
        private System.Windows.Forms.Button medicineRequest;
        private System.Windows.Forms.Button notificationButton;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button requestAppointment;
        private System.Windows.Forms.Button cancelAppointment;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

