
namespace DoctorSubsystem_VS
{
    partial class CreatePrescriptionForm
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
            this.patientLabel = new System.Windows.Forms.Label();
            this.patientsComboBox = new System.Windows.Forms.ComboBox();
            this.prescripNameLabel = new System.Windows.Forms.Label();
            this.prescripNameBox = new System.Windows.Forms.TextBox();
            this.refillsLabel = new System.Windows.Forms.Label();
            this.numRefillsBox = new System.Windows.Forms.TextBox();
            this.earliestRefillPicker = new System.Windows.Forms.DateTimePicker();
            this.medicineListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dosageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instructionsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.medicineLabel = new System.Windows.Forms.Label();
            this.addMedicineButton = new System.Windows.Forms.Button();
            this.medNameBox = new System.Windows.Forms.TextBox();
            this.medNameLabel = new System.Windows.Forms.Label();
            this.dosageLabel = new System.Windows.Forms.Label();
            this.dosageBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.instructionsBox = new System.Windows.Forms.TextBox();
            this.createPrescripButton = new System.Windows.Forms.Button();
            this.removeMedicineButton = new System.Windows.Forms.Button();
            this.existingMedCombo = new System.Windows.Forms.ComboBox();
            this.existingMedRadio = new System.Windows.Forms.RadioButton();
            this.newMedRadio = new System.Windows.Forms.RadioButton();
            this.refillDateCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(12, 9);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(56, 17);
            this.patientLabel.TabIndex = 0;
            this.patientLabel.Text = "Patient:";
            // 
            // patientsComboBox
            // 
            this.patientsComboBox.FormattingEnabled = true;
            this.patientsComboBox.Location = new System.Drawing.Point(74, 6);
            this.patientsComboBox.Name = "patientsComboBox";
            this.patientsComboBox.Size = new System.Drawing.Size(236, 24);
            this.patientsComboBox.TabIndex = 1;
            this.patientsComboBox.SelectedIndexChanged += new System.EventHandler(this.patientsComboBox_SelectedIndexChanged);
            // 
            // prescripNameLabel
            // 
            this.prescripNameLabel.AutoSize = true;
            this.prescripNameLabel.Location = new System.Drawing.Point(12, 41);
            this.prescripNameLabel.Name = "prescripNameLabel";
            this.prescripNameLabel.Size = new System.Drawing.Size(128, 17);
            this.prescripNameLabel.TabIndex = 2;
            this.prescripNameLabel.Text = "Prescription Name:";
            // 
            // prescripNameBox
            // 
            this.prescripNameBox.Enabled = false;
            this.prescripNameBox.Location = new System.Drawing.Point(146, 36);
            this.prescripNameBox.Name = "prescripNameBox";
            this.prescripNameBox.Size = new System.Drawing.Size(164, 22);
            this.prescripNameBox.TabIndex = 3;
            // 
            // refillsLabel
            // 
            this.refillsLabel.AutoSize = true;
            this.refillsLabel.Enabled = false;
            this.refillsLabel.Location = new System.Drawing.Point(12, 67);
            this.refillsLabel.Name = "refillsLabel";
            this.refillsLabel.Size = new System.Drawing.Size(120, 17);
            this.refillsLabel.TabIndex = 4;
            this.refillsLabel.Text = "Number of Refills:";
            // 
            // numRefillsBox
            // 
            this.numRefillsBox.Enabled = false;
            this.numRefillsBox.Location = new System.Drawing.Point(146, 64);
            this.numRefillsBox.Name = "numRefillsBox";
            this.numRefillsBox.Size = new System.Drawing.Size(100, 22);
            this.numRefillsBox.TabIndex = 5;
            this.numRefillsBox.TextChanged += new System.EventHandler(this.numRefillsBox_TextChanged);
            // 
            // earliestRefillPicker
            // 
            this.earliestRefillPicker.Enabled = false;
            this.earliestRefillPicker.Location = new System.Drawing.Point(74, 115);
            this.earliestRefillPicker.Name = "earliestRefillPicker";
            this.earliestRefillPicker.Size = new System.Drawing.Size(236, 22);
            this.earliestRefillPicker.TabIndex = 7;
            // 
            // medicineListView
            // 
            this.medicineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.dosageColumn,
            this.amountColumn,
            this.instructionsColumn});
            this.medicineListView.FullRowSelect = true;
            this.medicineListView.GridLines = true;
            this.medicineListView.HideSelection = false;
            this.medicineListView.Location = new System.Drawing.Point(364, 36);
            this.medicineListView.Name = "medicineListView";
            this.medicineListView.Size = new System.Drawing.Size(641, 402);
            this.medicineListView.TabIndex = 8;
            this.medicineListView.UseCompatibleStateImageBehavior = false;
            this.medicineListView.View = System.Windows.Forms.View.Details;
            this.medicineListView.SelectedIndexChanged += new System.EventHandler(this.medicineListView_SelectedIndexChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 152;
            // 
            // dosageColumn
            // 
            this.dosageColumn.Text = "Dosage";
            this.dosageColumn.Width = 68;
            // 
            // amountColumn
            // 
            this.amountColumn.Text = "Amount";
            // 
            // instructionsColumn
            // 
            this.instructionsColumn.Text = "Instructions";
            this.instructionsColumn.Width = 360;
            // 
            // medicineLabel
            // 
            this.medicineLabel.AutoSize = true;
            this.medicineLabel.Location = new System.Drawing.Point(361, 9);
            this.medicineLabel.Name = "medicineLabel";
            this.medicineLabel.Size = new System.Drawing.Size(75, 17);
            this.medicineLabel.TabIndex = 9;
            this.medicineLabel.Text = "Medicines:";
            // 
            // addMedicineButton
            // 
            this.addMedicineButton.Enabled = false;
            this.addMedicineButton.Location = new System.Drawing.Point(15, 464);
            this.addMedicineButton.Name = "addMedicineButton";
            this.addMedicineButton.Size = new System.Drawing.Size(144, 40);
            this.addMedicineButton.TabIndex = 10;
            this.addMedicineButton.Text = "Add Medicine";
            this.addMedicineButton.UseVisualStyleBackColor = true;
            this.addMedicineButton.Click += new System.EventHandler(this.addMedicineButton_Click);
            // 
            // medNameBox
            // 
            this.medNameBox.Enabled = false;
            this.medNameBox.Location = new System.Drawing.Point(127, 213);
            this.medNameBox.Name = "medNameBox";
            this.medNameBox.Size = new System.Drawing.Size(183, 22);
            this.medNameBox.TabIndex = 11;
            this.medNameBox.TextChanged += new System.EventHandler(this.medNameBox_TextChanged);
            // 
            // medNameLabel
            // 
            this.medNameLabel.AutoSize = true;
            this.medNameLabel.Enabled = false;
            this.medNameLabel.Location = new System.Drawing.Point(12, 216);
            this.medNameLabel.Name = "medNameLabel";
            this.medNameLabel.Size = new System.Drawing.Size(109, 17);
            this.medNameLabel.TabIndex = 12;
            this.medNameLabel.Text = "Medicine Name:";
            // 
            // dosageLabel
            // 
            this.dosageLabel.AutoSize = true;
            this.dosageLabel.Enabled = false;
            this.dosageLabel.Location = new System.Drawing.Point(12, 244);
            this.dosageLabel.Name = "dosageLabel";
            this.dosageLabel.Size = new System.Drawing.Size(94, 17);
            this.dosageLabel.TabIndex = 13;
            this.dosageLabel.Text = "Dosage (mg):";
            // 
            // dosageBox
            // 
            this.dosageBox.Enabled = false;
            this.dosageBox.Location = new System.Drawing.Point(112, 241);
            this.dosageBox.Name = "dosageBox";
            this.dosageBox.Size = new System.Drawing.Size(53, 22);
            this.dosageBox.TabIndex = 14;
            this.dosageBox.TextChanged += new System.EventHandler(this.dosageBox_TextChanged);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Enabled = false;
            this.amountLabel.Location = new System.Drawing.Point(171, 244);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(60, 17);
            this.amountLabel.TabIndex = 15;
            this.amountLabel.Text = "Amount:";
            // 
            // amountBox
            // 
            this.amountBox.Enabled = false;
            this.amountBox.Location = new System.Drawing.Point(233, 241);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(77, 22);
            this.amountBox.TabIndex = 16;
            this.amountBox.TextChanged += new System.EventHandler(this.amountBox_TextChanged);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Enabled = false;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 268);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(84, 17);
            this.instructionsLabel.TabIndex = 17;
            this.instructionsLabel.Text = "Instructions:";
            // 
            // instructionsBox
            // 
            this.instructionsBox.Enabled = false;
            this.instructionsBox.Location = new System.Drawing.Point(15, 288);
            this.instructionsBox.Multiline = true;
            this.instructionsBox.Name = "instructionsBox";
            this.instructionsBox.Size = new System.Drawing.Size(295, 170);
            this.instructionsBox.TabIndex = 18;
            this.instructionsBox.TextChanged += new System.EventHandler(this.instructionsBox_TextChanged);
            // 
            // createPrescripButton
            // 
            this.createPrescripButton.Enabled = false;
            this.createPrescripButton.Location = new System.Drawing.Point(166, 464);
            this.createPrescripButton.Name = "createPrescripButton";
            this.createPrescripButton.Size = new System.Drawing.Size(144, 40);
            this.createPrescripButton.TabIndex = 19;
            this.createPrescripButton.Text = "Create Prescription";
            this.createPrescripButton.UseVisualStyleBackColor = true;
            this.createPrescripButton.Click += new System.EventHandler(this.createPrescripButton_Click);
            // 
            // removeMedicineButton
            // 
            this.removeMedicineButton.Enabled = false;
            this.removeMedicineButton.Location = new System.Drawing.Point(866, 6);
            this.removeMedicineButton.Name = "removeMedicineButton";
            this.removeMedicineButton.Size = new System.Drawing.Size(139, 23);
            this.removeMedicineButton.TabIndex = 20;
            this.removeMedicineButton.Text = "Remove Medicine";
            this.removeMedicineButton.UseVisualStyleBackColor = true;
            // 
            // existingMedCombo
            // 
            this.existingMedCombo.Enabled = false;
            this.existingMedCombo.FormattingEnabled = true;
            this.existingMedCombo.Location = new System.Drawing.Point(158, 143);
            this.existingMedCombo.Name = "existingMedCombo";
            this.existingMedCombo.Size = new System.Drawing.Size(152, 24);
            this.existingMedCombo.TabIndex = 21;
            this.existingMedCombo.SelectedIndexChanged += new System.EventHandler(this.existingMedCombo_SelectedIndexChanged);
            // 
            // existingMedRadio
            // 
            this.existingMedRadio.AutoSize = true;
            this.existingMedRadio.Enabled = false;
            this.existingMedRadio.Location = new System.Drawing.Point(15, 146);
            this.existingMedRadio.Name = "existingMedRadio";
            this.existingMedRadio.Size = new System.Drawing.Size(137, 21);
            this.existingMedRadio.TabIndex = 24;
            this.existingMedRadio.TabStop = true;
            this.existingMedRadio.Text = "Existing Medicine";
            this.existingMedRadio.UseVisualStyleBackColor = true;
            this.existingMedRadio.CheckedChanged += new System.EventHandler(this.existingMedRadio_CheckedChanged);
            // 
            // newMedRadio
            // 
            this.newMedRadio.AutoSize = true;
            this.newMedRadio.Enabled = false;
            this.newMedRadio.Location = new System.Drawing.Point(15, 186);
            this.newMedRadio.Name = "newMedRadio";
            this.newMedRadio.Size = new System.Drawing.Size(145, 21);
            this.newMedRadio.TabIndex = 25;
            this.newMedRadio.TabStop = true;
            this.newMedRadio.Text = "Add New Medicine";
            this.newMedRadio.UseVisualStyleBackColor = true;
            this.newMedRadio.CheckedChanged += new System.EventHandler(this.newMedRadio_CheckedChanged);
            // 
            // refillDateCheck
            // 
            this.refillDateCheck.AutoSize = true;
            this.refillDateCheck.Enabled = false;
            this.refillDateCheck.Location = new System.Drawing.Point(15, 88);
            this.refillDateCheck.Name = "refillDateCheck";
            this.refillDateCheck.Size = new System.Drawing.Size(171, 21);
            this.refillDateCheck.TabIndex = 26;
            this.refillDateCheck.Text = "Earliest Date For Refill";
            this.refillDateCheck.UseVisualStyleBackColor = true;
            // 
            // CreatePrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 516);
            this.Controls.Add(this.refillDateCheck);
            this.Controls.Add(this.newMedRadio);
            this.Controls.Add(this.existingMedRadio);
            this.Controls.Add(this.existingMedCombo);
            this.Controls.Add(this.removeMedicineButton);
            this.Controls.Add(this.createPrescripButton);
            this.Controls.Add(this.instructionsBox);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.dosageBox);
            this.Controls.Add(this.dosageLabel);
            this.Controls.Add(this.medNameLabel);
            this.Controls.Add(this.medNameBox);
            this.Controls.Add(this.addMedicineButton);
            this.Controls.Add(this.medicineLabel);
            this.Controls.Add(this.medicineListView);
            this.Controls.Add(this.earliestRefillPicker);
            this.Controls.Add(this.numRefillsBox);
            this.Controls.Add(this.refillsLabel);
            this.Controls.Add(this.prescripNameBox);
            this.Controls.Add(this.prescripNameLabel);
            this.Controls.Add(this.patientsComboBox);
            this.Controls.Add(this.patientLabel);
            this.Name = "CreatePrescriptionForm";
            this.Text = "Create Prescription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.ComboBox patientsComboBox;
        private System.Windows.Forms.Label prescripNameLabel;
        private System.Windows.Forms.TextBox prescripNameBox;
        private System.Windows.Forms.Label refillsLabel;
        private System.Windows.Forms.TextBox numRefillsBox;
        private System.Windows.Forms.DateTimePicker earliestRefillPicker;
        private System.Windows.Forms.ListView medicineListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader dosageColumn;
        private System.Windows.Forms.ColumnHeader amountColumn;
        private System.Windows.Forms.ColumnHeader instructionsColumn;
        private System.Windows.Forms.Label medicineLabel;
        private System.Windows.Forms.Button addMedicineButton;
        private System.Windows.Forms.TextBox medNameBox;
        private System.Windows.Forms.Label medNameLabel;
        private System.Windows.Forms.Label dosageLabel;
        private System.Windows.Forms.TextBox dosageBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.TextBox instructionsBox;
        private System.Windows.Forms.Button createPrescripButton;
        private System.Windows.Forms.Button removeMedicineButton;
        private System.Windows.Forms.ComboBox existingMedCombo;
        private System.Windows.Forms.RadioButton existingMedRadio;
        private System.Windows.Forms.RadioButton newMedRadio;
        private System.Windows.Forms.CheckBox refillDateCheck;
    }
}