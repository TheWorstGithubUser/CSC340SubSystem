namespace PatientSubsystem
{
    partial class Main
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
            this.appointmentListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkRecordsButton
            // 
            this.checkRecordsButton.Location = new System.Drawing.Point(12, 68);
            this.checkRecordsButton.Name = "checkRecordsButton";
            this.checkRecordsButton.Size = new System.Drawing.Size(383, 49);
            this.checkRecordsButton.TabIndex = 0;
            this.checkRecordsButton.Text = "Check Medical Records";
            this.checkRecordsButton.UseVisualStyleBackColor = true;
            this.checkRecordsButton.Click += new System.EventHandler(this.checkRecordsButton_Click);
            // 
            // phoneCallRequest
            // 
            this.phoneCallRequest.Location = new System.Drawing.Point(12, 288);
            this.phoneCallRequest.Name = "phoneCallRequest";
            this.phoneCallRequest.Size = new System.Drawing.Size(383, 49);
            this.phoneCallRequest.TabIndex = 1;
            this.phoneCallRequest.Text = "Request Phone Call From Doctor";
            this.phoneCallRequest.UseVisualStyleBackColor = true;
            this.phoneCallRequest.Click += new System.EventHandler(this.phoneCallRequest_Click);
            // 
            // medicineRequest
            // 
            this.medicineRequest.Location = new System.Drawing.Point(12, 123);
            this.medicineRequest.Name = "medicineRequest";
            this.medicineRequest.Size = new System.Drawing.Size(383, 49);
            this.medicineRequest.TabIndex = 2;
            this.medicineRequest.Text = "Request Medicine";
            this.medicineRequest.UseVisualStyleBackColor = true;
            this.medicineRequest.Click += new System.EventHandler(this.medicineRequest_Click);
            // 
            // notificationButton
            // 
            this.notificationButton.Location = new System.Drawing.Point(12, 178);
            this.notificationButton.Name = "notificationButton";
            this.notificationButton.Size = new System.Drawing.Size(383, 49);
            this.notificationButton.TabIndex = 3;
            this.notificationButton.Text = "Recieved Notifications";
            this.notificationButton.UseVisualStyleBackColor = true;
            this.notificationButton.Click += new System.EventHandler(this.notificationButton_Click);
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.Location = new System.Drawing.Point(401, 113);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.Size = new System.Drawing.Size(383, 22);
            this.appointmentDatePicker.TabIndex = 4;
            this.appointmentDatePicker.ValueChanged += new System.EventHandler(this.appointmentDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(361, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // requestAppointment
            // 
            this.requestAppointment.Location = new System.Drawing.Point(12, 233);
            this.requestAppointment.Name = "requestAppointment";
            this.requestAppointment.Size = new System.Drawing.Size(383, 49);
            this.requestAppointment.TabIndex = 6;
            this.requestAppointment.Text = "Request Appointment";
            this.requestAppointment.UseVisualStyleBackColor = true;
            this.requestAppointment.Click += new System.EventHandler(this.requestAppointment_Click);
            // 
            // cancelAppointment
            // 
            this.cancelAppointment.Location = new System.Drawing.Point(12, 343);
            this.cancelAppointment.Name = "cancelAppointment";
            this.cancelAppointment.Size = new System.Drawing.Size(383, 49);
            this.cancelAppointment.TabIndex = 7;
            this.cancelAppointment.Text = "Cancel Appointment";
            this.cancelAppointment.UseVisualStyleBackColor = true;
            this.cancelAppointment.Click += new System.EventHandler(this.cancelAppointment_Click);
            // 
            // appointmentListBox
            // 
            this.appointmentListBox.FormattingEnabled = true;
            this.appointmentListBox.ItemHeight = 16;
            this.appointmentListBox.Location = new System.Drawing.Point(405, 189);
            this.appointmentListBox.Name = "appointmentListBox";
            this.appointmentListBox.ScrollAlwaysVisible = true;
            this.appointmentListBox.Size = new System.Drawing.Size(379, 196);
            this.appointmentListBox.TabIndex = 8;
            this.appointmentListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(401, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Appointment to cancel\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(401, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select date for appointment/phone call";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.appointmentListBox);
            this.Controls.Add(this.cancelAppointment);
            this.Controls.Add(this.requestAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.notificationButton);
            this.Controls.Add(this.medicineRequest);
            this.Controls.Add(this.phoneCallRequest);
            this.Controls.Add(this.checkRecordsButton);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
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
        private System.Windows.Forms.ListBox appointmentListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

