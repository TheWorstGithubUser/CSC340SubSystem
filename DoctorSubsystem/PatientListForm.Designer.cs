
namespace DoctorSubsystem_VS
{
    partial class PatientListForm
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SearchNameButton = new System.Windows.Forms.Button();
            this.NamePrompt = new System.Windows.Forms.Label();
            this.patientListView = new System.Windows.Forms.ListView();
            this.lName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.insurance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpenRecordButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(179, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(346, 22);
            this.searchBox.TabIndex = 0;
            // 
            // SearchNameButton
            // 
            this.SearchNameButton.Location = new System.Drawing.Point(531, 12);
            this.SearchNameButton.Name = "SearchNameButton";
            this.SearchNameButton.Size = new System.Drawing.Size(75, 23);
            this.SearchNameButton.TabIndex = 1;
            this.SearchNameButton.Text = "Search";
            this.SearchNameButton.UseVisualStyleBackColor = true;
            this.SearchNameButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // NamePrompt
            // 
            this.NamePrompt.AutoSize = true;
            this.NamePrompt.Location = new System.Drawing.Point(12, 12);
            this.NamePrompt.Name = "NamePrompt";
            this.NamePrompt.Size = new System.Drawing.Size(148, 17);
            this.NamePrompt.TabIndex = 2;
            this.NamePrompt.Text = "Search by Last Name:";
            // 
            // patientListView
            // 
            this.patientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lName,
            this.fName,
            this.DoB,
            this.insurance,
            this.sex});
            this.patientListView.FullRowSelect = true;
            this.patientListView.GridLines = true;
            this.patientListView.HideSelection = false;
            this.patientListView.Location = new System.Drawing.Point(15, 40);
            this.patientListView.Name = "patientListView";
            this.patientListView.Size = new System.Drawing.Size(591, 331);
            this.patientListView.TabIndex = 3;
            this.patientListView.UseCompatibleStateImageBehavior = false;
            this.patientListView.View = System.Windows.Forms.View.Details;
            // 
            // lName
            // 
            this.lName.Text = "Last Name";
            this.lName.Width = 130;
            // 
            // fName
            // 
            this.fName.Text = "First Name";
            this.fName.Width = 130;
            // 
            // DoB
            // 
            this.DoB.Text = "Date of Birth";
            this.DoB.Width = 130;
            // 
            // insurance
            // 
            this.insurance.Text = "Insurer";
            this.insurance.Width = 161;
            // 
            // sex
            // 
            this.sex.Text = "Sex";
            this.sex.Width = 35;
            // 
            // OpenRecordButton
            // 
            this.OpenRecordButton.Location = new System.Drawing.Point(15, 377);
            this.OpenRecordButton.Name = "OpenRecordButton";
            this.OpenRecordButton.Size = new System.Drawing.Size(148, 49);
            this.OpenRecordButton.TabIndex = 4;
            this.OpenRecordButton.Text = "Open Record";
            this.OpenRecordButton.UseVisualStyleBackColor = true;
            this.OpenRecordButton.Click += new System.EventHandler(this.OpenRecordButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(458, 377);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(148, 49);
            this.showAllButton.TabIndex = 5;
            this.showAllButton.Text = "Show all Patients";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // PatientListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.OpenRecordButton);
            this.Controls.Add(this.patientListView);
            this.Controls.Add(this.NamePrompt);
            this.Controls.Add(this.SearchNameButton);
            this.Controls.Add(this.searchBox);
            this.Name = "PatientListForm";
            this.Text = "Patient List";
            this.Load += new System.EventHandler(this.PatientListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button SearchNameButton;
        private System.Windows.Forms.Label NamePrompt;
        private System.Windows.Forms.ListView patientListView;
        private System.Windows.Forms.ColumnHeader lName;
        private System.Windows.Forms.ColumnHeader fName;
        private System.Windows.Forms.ColumnHeader DoB;
        private System.Windows.Forms.ColumnHeader insurance;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.Button OpenRecordButton;
        private System.Windows.Forms.Button showAllButton;
    }
}