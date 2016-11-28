using System;
using System.Windows.Forms;
using System.Drawing;
using WorkTimer.logic;

namespace WorkTimer
{
    class WorkTimerApplicationContext : ApplicationContext 
    {
        private NotifyIcon trayIcon;
        private Timer timer;
        private LoginTimeFile loginTimeFile;

        public WorkTimerApplicationContext()
        {
            loginTimeFile = new LoginTimeFile();

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            InitializeComponent();
            trayIcon.Visible = true;
        }

        private void InitializeComponent()
        {
            ContextMenuStrip trayMenu;
            ToolStripMenuItem updateMenuItem;
            ToolStripMenuItem exitMenuItem;

            trayIcon = new NotifyIcon();
            trayIcon.Icon = Properties.Resources.AppIcon;
            
            trayMenu = new ContextMenuStrip();
            trayMenu.SuspendLayout();
            updateMenuItem = new ToolStripMenuItem();
            trayMenu.Items.Add(updateMenuItem);
            trayMenu.Items.Add(new ToolStripSeparator());
            exitMenuItem = new ToolStripMenuItem();
            trayMenu.Items.Add(exitMenuItem);

            updateMenuItem.Click += new EventHandler(this.UpdateMenuItem_Click);
            updateMenuItem.Text = "Update";
            updateMenuItem.Font = new Font(updateMenuItem.Font, updateMenuItem.Font.Style | FontStyle.Bold);
            exitMenuItem.Click += new EventHandler(this.ExitMenuItem_Click);
            exitMenuItem.Text = "Exit";
            trayMenu.ResumeLayout(false);

            trayIcon.Text = loginTimeFile.GetStartAndEndString();
            trayIcon.ContextMenuStrip = trayMenu;
            trayIcon.MouseDoubleClick += new MouseEventHandler(trayIcon_MouseDoubleClick);
            trayIcon.Visible = true;

            timer = new Timer();
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Interval = 1000 * 60; /* One minute */
            timer.Start();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            timer.Stop();

            DateTime now = DateTime.Now;
            DateTime lunchDateTime = DateTime.Parse(WorkTimerProperties.DefaultLunchTime);
            DateTime lunchStartWarningTime = lunchDateTime.AddMinutes(-5); /* 5 minutes before lunch actually starts */
            DateTime lunchEndWarningTime = lunchDateTime.AddMinutes(60); /* Warn for maximal 1 hour */

            if (now >= lunchStartWarningTime && now < lunchEndWarningTime)
            {
                //MessageBox.Show("should lunch now");
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoUpdate();
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e)
        {
            DoUpdate();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
 
        private void DoUpdate()
        {
            timer.Stop();

            loginTimeFile = new LoginTimeFile();

            UpdateTimerForm form = new UpdateTimerForm(loginTimeFile.GetStartTime());
            if (form.ShowDialog() == DialogResult.OK)
            {
                loginTimeFile.UpdateFile(form.LoginTime, false);
                trayIcon.Text = loginTimeFile.GetStartAndEndString();
            }

            timer.Start();
        }

    }
}
