
namespace DoctorSubsystem_VS
{
    partial class PatientRecordForm
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
            this.recordView = new System.Windows.Forms.ListView();
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pendingView = new System.Windows.Forms.ListView();
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.receivedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moveToRecordButton = new System.Windows.Forms.Button();
            this.prescriptionsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // recordView
            // 
            this.recordView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumn,
            this.itemColumn});
            this.recordView.FullRowSelect = true;
            this.recordView.GridLines = true;
            this.recordView.HideSelection = false;
            this.recordView.LabelWrap = false;
            this.recordView.Location = new System.Drawing.Point(12, 29);
            this.recordView.Name = "recordView";
            this.recordView.Size = new System.Drawing.Size(304, 359);
            this.recordView.TabIndex = 0;
            this.recordView.UseCompatibleStateImageBehavior = false;
            this.recordView.View = System.Windows.Forms.View.Details;
            this.recordView.SelectedIndexChanged += new System.EventHandler(this.recordView_SelectedIndexChanged);
            // 
            // dateColumn
            // 
            this.dateColumn.Tag = "";
            this.dateColumn.Text = "Date";
            this.dateColumn.Width = 120;
            // 
            // itemColumn
            // 
            this.itemColumn.Text = "Action";
            this.itemColumn.Width = 180;
            // 
            // pendingView
            // 
            this.pendingView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.receivedColumn});
            this.pendingView.FullRowSelect = true;
            this.pendingView.GridLines = true;
            this.pendingView.HideSelection = false;
            this.pendingView.LabelWrap = false;
            this.pendingView.Location = new System.Drawing.Point(360, 29);
            this.pendingView.Name = "pendingView";
            this.pendingView.Size = new System.Drawing.Size(255, 359);
            this.pendingView.TabIndex = 1;
            this.pendingView.UseCompatibleStateImageBehavior = false;
            this.pendingView.View = System.Windows.Forms.View.Details;
            this.pendingView.SelectedIndexChanged += new System.EventHandler(this.pendingView_SelectedIndexChanged);
            // 
            // idColumn
            // 
            this.idColumn.Text = "Prescription #";
            this.idColumn.Width = 171;
            // 
            // receivedColumn
            // 
            this.receivedColumn.Text = "Received?";
            this.receivedColumn.Width = 80;
            // 
            // moveToRecordButton
            // 
            this.moveToRecordButton.Enabled = false;
            this.moveToRecordButton.Location = new System.Drawing.Point(360, 394);
            this.moveToRecordButton.Name = "moveToRecordButton";
            this.moveToRecordButton.Size = new System.Drawing.Size(147, 44);
            this.moveToRecordButton.TabIndex = 2;
            this.moveToRecordButton.Text = "Add to Record";
            this.moveToRecordButton.UseVisualStyleBackColor = true;
            this.moveToRecordButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prescriptionsLabel
            // 
            this.prescriptionsLabel.AutoSize = true;
            this.prescriptionsLabel.Location = new System.Drawing.Point(357, 9);
            this.prescriptionsLabel.Name = "prescriptionsLabel";
            this.prescriptionsLabel.Size = new System.Drawing.Size(150, 17);
            this.prescriptionsLabel.TabIndex = 3;
            this.prescriptionsLabel.Text = "Pending Prescriptions:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(164, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Patient\'s Medical Record";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Review";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "View Record Item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PatientRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.prescriptionsLabel);
            this.Controls.Add(this.moveToRecordButton);
            this.Controls.Add(this.pendingView);
            this.Controls.Add(this.recordView);
            this.Name = "PatientRecordForm";
            this.Text = "Patient Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView recordView;
        private System.Windows.Forms.ListView pendingView;
        private System.Windows.Forms.Button moveToRecordButton;
        private System.Windows.Forms.Label prescriptionsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader itemColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader receivedColumn;
    }
}