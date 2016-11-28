namespace WorkTimer
{
    partial class UpdateTimerForm
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
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.cbxPause = new System.Windows.Forms.ComboBox();
            this.lblPause = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(77, 45);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(61, 20);
            this.dtpStartTime.TabIndex = 0;
            this.dtpStartTime.ValueChanged += new System.EventHandler(this.dtpStartTime_ValueChanged);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(17, 45);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(54, 13);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start time:";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "HH:mm";
            this.dtpEndTime.Enabled = false;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(77, 71);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(61, 20);
            this.dtpEndTime.TabIndex = 2;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(17, 71);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(51, 13);
            this.lblEndTime.TabIndex = 3;
            this.lblEndTime.Text = "End time:";
            // 
            // cbxPause
            // 
            this.cbxPause.DisplayMember = "1";
            this.cbxPause.FormattingEnabled = true;
            this.cbxPause.Items.AddRange(new object[] {
            "30",
            "45",
            "60"});
            this.cbxPause.Location = new System.Drawing.Point(223, 45);
            this.cbxPause.Name = "cbxPause";
            this.cbxPause.Size = new System.Drawing.Size(48, 21);
            this.cbxPause.TabIndex = 4;
            this.cbxPause.SelectedIndexChanged += new System.EventHandler(this.cbxPause_SelectedIndexChanged);
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Location = new System.Drawing.Point(177, 48);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(40, 13);
            this.lblPause.TabIndex = 5;
            this.lblPause.Text = "Pause:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(117, 123);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(201, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxDate
            // 
            this.tbxDate.Location = new System.Drawing.Point(20, 13);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.ReadOnly = true;
            this.tbxDate.Size = new System.Drawing.Size(251, 20);
            this.tbxDate.TabIndex = 8;
            // 
            // UpdateTimerForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(288, 159);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.cbxPause);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.dtpStartTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateTimerForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLoginTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.ComboBox cbxPause;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxDate;
    }
}

