
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.prescriptionsLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detailsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.receivedColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumn,
            this.itemColumn,
            this.detailsColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(486, 359);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idColumn,
            this.receivedColumn});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.LabelWrap = false;
            this.listView2.Location = new System.Drawing.Point(533, 29);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(255, 359);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add to Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prescriptionsLabel
            // 
            this.prescriptionsLabel.AutoSize = true;
            this.prescriptionsLabel.Location = new System.Drawing.Point(530, 9);
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
            this.button2.Location = new System.Drawing.Point(686, 394);
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
            // dateColumn
            // 
            this.dateColumn.Tag = "";
            this.dateColumn.Text = "Date";
            this.dateColumn.Width = 102;
            // 
            // itemColumn
            // 
            this.itemColumn.Text = "Action";
            this.itemColumn.Width = 110;
            // 
            // detailsColumn
            // 
            this.detailsColumn.Text = "Details";
            this.detailsColumn.Width = 265;
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
            // PatientRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.prescriptionsLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "PatientRecordForm";
            this.Text = "Patient Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label prescriptionsLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader itemColumn;
        private System.Windows.Forms.ColumnHeader detailsColumn;
        private System.Windows.Forms.ColumnHeader idColumn;
        private System.Windows.Forms.ColumnHeader receivedColumn;
    }
}