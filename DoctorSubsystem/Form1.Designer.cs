
namespace DoctorSubsystem_VS
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
            this.showNewNotifsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.notifsListView = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReceivedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BodyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openPatientListButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showNewNotifsButton
            // 
            this.showNewNotifsButton.Location = new System.Drawing.Point(12, 12);
            this.showNewNotifsButton.Name = "showNewNotifsButton";
            this.showNewNotifsButton.Size = new System.Drawing.Size(172, 51);
            this.showNewNotifsButton.TabIndex = 0;
            this.showNewNotifsButton.Text = "New Notifications";
            this.showNewNotifsButton.UseVisualStyleBackColor = true;
            this.showNewNotifsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Prescription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifsListView
            // 
            this.notifsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHeader,
            this.ReceivedHeader,
            this.BodyHeader});
            this.notifsListView.FullRowSelect = true;
            this.notifsListView.GridLines = true;
            this.notifsListView.HideSelection = false;
            this.notifsListView.Location = new System.Drawing.Point(12, 69);
            this.notifsListView.Name = "notifsListView";
            this.notifsListView.Size = new System.Drawing.Size(946, 265);
            this.notifsListView.TabIndex = 2;
            this.notifsListView.UseCompatibleStateImageBehavior = false;
            this.notifsListView.View = System.Windows.Forms.View.Details;
            // 
            // IDHeader
            // 
            this.IDHeader.Tag = "ID";
            this.IDHeader.Text = "ID";
            this.IDHeader.Width = 87;
            // 
            // ReceivedHeader
            // 
            this.ReceivedHeader.Text = "Received";
            this.ReceivedHeader.Width = 87;
            // 
            // BodyHeader
            // 
            this.BodyHeader.Text = "Body";
            this.BodyHeader.Width = 1000;
            // 
            // openPatientListButton
            // 
            this.openPatientListButton.BackColor = System.Drawing.SystemColors.Window;
            this.openPatientListButton.Location = new System.Drawing.Point(368, 12);
            this.openPatientListButton.Name = "openPatientListButton";
            this.openPatientListButton.Size = new System.Drawing.Size(172, 51);
            this.openPatientListButton.TabIndex = 3;
            this.openPatientListButton.Text = "Patient List";
            this.openPatientListButton.UseVisualStyleBackColor = false;
            this.openPatientListButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(191, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "View Request";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 345);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.openPatientListButton);
            this.Controls.Add(this.notifsListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showNewNotifsButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Doctor Subsystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showNewNotifsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView notifsListView;
        private System.Windows.Forms.ColumnHeader IDHeader;
        private System.Windows.Forms.ColumnHeader ReceivedHeader;
        private System.Windows.Forms.ColumnHeader BodyHeader;
        private System.Windows.Forms.Button openPatientListButton;
        private System.Windows.Forms.Button button4;
    }
}

