using System;
using System.Windows.Forms;

namespace WorkTimer
{
    public partial class UpdateTimerForm : Form
    {
        private WorkDayInterval loginTime;

        public WorkDayInterval LoginTime
        {
            get { return loginTime; }
        }
        
        public UpdateTimerForm(DateTime startTime)
        {
            this.loginTime = new WorkDayInterval();
            this.loginTime.startTime = startTime; 
            this.Icon = WorkTimer.Properties.Resources.AppIcon;

            InitializeComponent();
        }

        private void FormLoginTime_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.AppIcon;
            dtpStartTime.Value = loginTime.startTime;
            cbxPause.SelectedIndex = 0;
            DateTime today = DateTime.Now;
            tbxDate.Text = String.Format("{0} - {1,2:00}/{2,2:00}/{3,4} - {4,2:00}:{5,2:00}",
                today.DayOfWeek, today.Day, today.Month, today.Year, today.Hour, today.Minute);
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            loginTime.startTime = dtpStartTime.Value;
            setEndTime();
        }

        private void cbxPause_SelectedIndexChanged(object sender, EventArgs e)
        {
            loginTime.pauseMinutes = Convert.ToDouble((String)cbxPause.SelectedItem);
            setEndTime();
        }

        private void setEndTime()
        {
            dtpEndTime.Value = loginTime.getEndTime();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
