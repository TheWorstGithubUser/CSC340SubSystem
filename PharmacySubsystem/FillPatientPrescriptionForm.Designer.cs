﻿namespace PharmacySubsystem
{
    partial class FillPatientPrescriptionForm
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
            fillPatientPrescriptionPatientsLabel = new Label();
            fillPatientPrescriptionPatientsComboBox = new ComboBox();
            fillPatientPrescriptionPrescriptionsLabel = new Label();
            fillPatientPrescriptionPrescriptionsComboBox = new ComboBox();
            fillPatientPrescriptionsFillButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            fillPatientPrescriptionsPickupButton = new Button();
            SuspendLayout();
            // 
            // fillPatientPrescriptionPatientsLabel
            // 
            fillPatientPrescriptionPatientsLabel.AutoSize = true;
            fillPatientPrescriptionPatientsLabel.ForeColor = Color.White;
            fillPatientPrescriptionPatientsLabel.Location = new Point(38, 12);
            fillPatientPrescriptionPatientsLabel.Name = "fillPatientPrescriptionPatientsLabel";
            fillPatientPrescriptionPatientsLabel.Size = new Size(90, 15);
            fillPatientPrescriptionPatientsLabel.TabIndex = 0;
            fillPatientPrescriptionPatientsLabel.Text = "Select a Patient:";
            // 
            // fillPatientPrescriptionPatientsComboBox
            // 
            fillPatientPrescriptionPatientsComboBox.BackColor = Color.FromArgb(22, 22, 22);
            fillPatientPrescriptionPatientsComboBox.ForeColor = Color.White;
            fillPatientPrescriptionPatientsComboBox.FormattingEnabled = true;
            fillPatientPrescriptionPatientsComboBox.Location = new Point(134, 9);
            fillPatientPrescriptionPatientsComboBox.Name = "fillPatientPrescriptionPatientsComboBox";
            fillPatientPrescriptionPatientsComboBox.Size = new Size(194, 23);
            fillPatientPrescriptionPatientsComboBox.Sorted = true;
            fillPatientPrescriptionPatientsComboBox.TabIndex = 1;
            fillPatientPrescriptionPatientsComboBox.SelectedIndexChanged += fillPatientPrescriptionPatientsComboBox_SelectedIndexChanged;
            // 
            // fillPatientPrescriptionPrescriptionsLabel
            // 
            fillPatientPrescriptionPrescriptionsLabel.AutoSize = true;
            fillPatientPrescriptionPrescriptionsLabel.ForeColor = Color.White;
            fillPatientPrescriptionPrescriptionsLabel.Location = new Point(12, 55);
            fillPatientPrescriptionPrescriptionsLabel.Name = "fillPatientPrescriptionPrescriptionsLabel";
            fillPatientPrescriptionPrescriptionsLabel.Size = new Size(116, 15);
            fillPatientPrescriptionPrescriptionsLabel.TabIndex = 2;
            fillPatientPrescriptionPrescriptionsLabel.Text = "Select a Prescription:";
            // 
            // fillPatientPrescriptionPrescriptionsComboBox
            // 
            fillPatientPrescriptionPrescriptionsComboBox.BackColor = Color.FromArgb(22, 22, 22);
            fillPatientPrescriptionPrescriptionsComboBox.Enabled = false;
            fillPatientPrescriptionPrescriptionsComboBox.ForeColor = Color.White;
            fillPatientPrescriptionPrescriptionsComboBox.FormattingEnabled = true;
            fillPatientPrescriptionPrescriptionsComboBox.Location = new Point(134, 52);
            fillPatientPrescriptionPrescriptionsComboBox.Name = "fillPatientPrescriptionPrescriptionsComboBox";
            fillPatientPrescriptionPrescriptionsComboBox.Size = new Size(194, 23);
            fillPatientPrescriptionPrescriptionsComboBox.TabIndex = 3;
            fillPatientPrescriptionPrescriptionsComboBox.SelectedIndexChanged += fillPatientPrescriptionPrescriptionsComboBox_SelectedIndexChanged;
            // 
            // fillPatientPrescriptionsFillButton
            // 
            fillPatientPrescriptionsFillButton.BackColor = Color.FromArgb(22, 22, 22);
            fillPatientPrescriptionsFillButton.ForeColor = Color.White;
            fillPatientPrescriptionsFillButton.Location = new Point(12, 96);
            fillPatientPrescriptionsFillButton.Name = "fillPatientPrescriptionsFillButton";
            fillPatientPrescriptionsFillButton.Size = new Size(153, 62);
            fillPatientPrescriptionsFillButton.TabIndex = 4;
            fillPatientPrescriptionsFillButton.Text = "Fill Prescription";
            fillPatientPrescriptionsFillButton.UseVisualStyleBackColor = false;
            fillPatientPrescriptionsFillButton.Click += fillPatientPrescriptionsFillButton_Click;
            // 
            // fillPatientPrescriptionsPickupButton
            // 
            fillPatientPrescriptionsPickupButton.BackColor = Color.FromArgb(22, 22, 22);
            fillPatientPrescriptionsPickupButton.ForeColor = Color.White;
            fillPatientPrescriptionsPickupButton.Location = new Point(175, 96);
            fillPatientPrescriptionsPickupButton.Name = "fillPatientPrescriptionsPickupButton";
            fillPatientPrescriptionsPickupButton.Size = new Size(153, 62);
            fillPatientPrescriptionsPickupButton.TabIndex = 5;
            fillPatientPrescriptionsPickupButton.Text = "Pickup Prescription";
            fillPatientPrescriptionsPickupButton.UseVisualStyleBackColor = false;
            fillPatientPrescriptionsPickupButton.Click += fillPatientPrescriptionsPickupButton_Click;
            // 
            // FillPatientPrescriptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(349, 193);
            Controls.Add(fillPatientPrescriptionsPickupButton);
            Controls.Add(fillPatientPrescriptionsFillButton);
            Controls.Add(fillPatientPrescriptionPrescriptionsComboBox);
            Controls.Add(fillPatientPrescriptionPrescriptionsLabel);
            Controls.Add(fillPatientPrescriptionPatientsComboBox);
            Controls.Add(fillPatientPrescriptionPatientsLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FillPatientPrescriptionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fill Patient Prescription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fillPatientPrescriptionPatientsLabel;
        private ComboBox fillPatientPrescriptionPatientsComboBox;
        private Label fillPatientPrescriptionPrescriptionsLabel;
        private ComboBox fillPatientPrescriptionPrescriptionsComboBox;
        private Button fillPatientPrescriptionsFillButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button fillPatientPrescriptionsPickupButton;
    }
}