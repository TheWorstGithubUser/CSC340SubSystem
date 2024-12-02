namespace PharmacySubsystem
{
    partial class PharmacyAppMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            newPrescriptionArrivalButton = new Button();
            notifyPatientButton = new Button();
            fillPatientPrescriptionButton = new Button();
            prescriptionPickupFormButton = new Button();
            patientListView = new ListView();
            patientListViewLastNameColumn = new ColumnHeader();
            patientListViewMiddleNameColumn = new ColumnHeader();
            patientListViewFirstNameColumn = new ColumnHeader();
            patientListingLabel = new Label();
            newPrescriptionPollingTimer = new System.Windows.Forms.Timer(components);
            patientListingPollingTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // newPrescriptionArrivalButton
            // 
            newPrescriptionArrivalButton.BackColor = Color.FromArgb(22, 22, 22);
            newPrescriptionArrivalButton.ForeColor = Color.White;
            newPrescriptionArrivalButton.Location = new Point(12, 12);
            newPrescriptionArrivalButton.Name = "newPrescriptionArrivalButton";
            newPrescriptionArrivalButton.Size = new Size(153, 62);
            newPrescriptionArrivalButton.TabIndex = 0;
            newPrescriptionArrivalButton.Text = "New Prescription";
            newPrescriptionArrivalButton.UseVisualStyleBackColor = false;
            newPrescriptionArrivalButton.Click += newPrescriptionArrivalButton_Click;
            // 
            // notifyPatientButton
            // 
            notifyPatientButton.BackColor = Color.FromArgb(22, 22, 22);
            notifyPatientButton.ForeColor = Color.White;
            notifyPatientButton.Location = new Point(171, 12);
            notifyPatientButton.Name = "notifyPatientButton";
            notifyPatientButton.Size = new Size(153, 62);
            notifyPatientButton.TabIndex = 1;
            notifyPatientButton.Text = "Notify Patient";
            notifyPatientButton.UseVisualStyleBackColor = false;
            notifyPatientButton.Click += notifyPatientButton_Click;
            // 
            // fillPatientPrescriptionButton
            // 
            fillPatientPrescriptionButton.BackColor = Color.FromArgb(22, 22, 22);
            fillPatientPrescriptionButton.ForeColor = Color.White;
            fillPatientPrescriptionButton.Location = new Point(330, 12);
            fillPatientPrescriptionButton.Name = "fillPatientPrescriptionButton";
            fillPatientPrescriptionButton.Size = new Size(153, 62);
            fillPatientPrescriptionButton.TabIndex = 2;
            fillPatientPrescriptionButton.Text = "Fill Patient Prescription";
            fillPatientPrescriptionButton.UseVisualStyleBackColor = false;
            // 
            // prescriptionPickupFormButton
            // 
            prescriptionPickupFormButton.BackColor = Color.FromArgb(22, 22, 22);
            prescriptionPickupFormButton.ForeColor = Color.White;
            prescriptionPickupFormButton.Location = new Point(489, 12);
            prescriptionPickupFormButton.Name = "prescriptionPickupFormButton";
            prescriptionPickupFormButton.Size = new Size(153, 62);
            prescriptionPickupFormButton.TabIndex = 3;
            prescriptionPickupFormButton.Text = "Prescription Pickup Form";
            prescriptionPickupFormButton.UseVisualStyleBackColor = false;
            // 
            // patientListView
            // 
            patientListView.BackColor = Color.White;
            patientListView.Columns.AddRange(new ColumnHeader[] { patientListViewLastNameColumn, patientListViewMiddleNameColumn, patientListViewFirstNameColumn });
            patientListView.FullRowSelect = true;
            patientListView.Location = new Point(12, 136);
            patientListView.MultiSelect = false;
            patientListView.Name = "patientListView";
            patientListView.Size = new Size(630, 263);
            patientListView.TabIndex = 4;
            patientListView.UseCompatibleStateImageBehavior = false;
            patientListView.View = View.Details;
            // 
            // patientListViewLastNameColumn
            // 
            patientListViewLastNameColumn.Text = "Last Name";
            patientListViewLastNameColumn.Width = 210;
            // 
            // patientListViewMiddleNameColumn
            // 
            patientListViewMiddleNameColumn.Text = "Middle Name";
            patientListViewMiddleNameColumn.Width = 210;
            // 
            // patientListViewFirstNameColumn
            // 
            patientListViewFirstNameColumn.Text = "First Name";
            patientListViewFirstNameColumn.Width = 200;
            // 
            // patientListingLabel
            // 
            patientListingLabel.AutoSize = true;
            patientListingLabel.Font = new Font("Chiller", 36F, FontStyle.Italic, GraphicsUnit.Point, 0);
            patientListingLabel.ForeColor = Color.Maroon;
            patientListingLabel.Location = new Point(219, 77);
            patientListingLabel.Name = "patientListingLabel";
            patientListingLabel.Size = new Size(231, 56);
            patientListingLabel.TabIndex = 5;
            patientListingLabel.Text = "Patient Listing";
            patientListingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // newPrescriptionPollingTimer
            // 
            newPrescriptionPollingTimer.Interval = 5000;
            // 
            // patientListingPollingTimer
            // 
            patientListingPollingTimer.Interval = 5000;
            // 
            // PharmacyAppMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(654, 411);
            Controls.Add(patientListingLabel);
            Controls.Add(patientListView);
            Controls.Add(prescriptionPickupFormButton);
            Controls.Add(fillPatientPrescriptionButton);
            Controls.Add(notifyPatientButton);
            Controls.Add(newPrescriptionArrivalButton);
            Name = "PharmacyAppMainForm";
            Text = "Pharmacy System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newPrescriptionArrivalButton;
        private Button notifyPatientButton;
        private Button fillPatientPrescriptionButton;
        private Button prescriptionPickupFormButton;
        private ListView patientListView;
        private ColumnHeader patientListViewLastNameColumn;
        private ColumnHeader patientListViewMiddleNameColumn;
        private ColumnHeader patientListViewFirstNameColumn;
        private Label patientListingLabel;
        private System.Windows.Forms.Timer newPrescriptionPollingTimer;
        private System.Windows.Forms.Timer patientListingPollingTimer;
    }
}
