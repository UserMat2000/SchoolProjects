
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PunchInOutApp
{
    
    public partial class PunchCard : Form
    {
        private bool isClockedIn = false;
        private List<DateTime> clockInTimes = new List<DateTime>();
        private List<TimeSpan> workDurations = new List<TimeSpan>();
        
        public PunchCard()
        {
            InitializeComponent();
           
        }

        private void ClockInButton_Click(object sender, EventArgs e)
        {
            if (isClockedIn)
            {
                MessageBox.Show("You are already clocked in.", "Clock In Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime clockInTime = DateTime.Now;
                clockInTimes.Add(clockInTime);
                isClockedIn = true;

                ClockInList.Items.Add(clockInTime.ToString("yyyy-MM-dd HH:mm:ss"));
                MessageBox.Show("Clocked in successfully.", "Clock In Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClockOutButton_Click(object sender, EventArgs e)
        {
            if (isClockedIn)
            {
                DateTime clockOutTime = DateTime.Now;
                TimeSpan workDuration = clockOutTime - clockInTimes[clockInTimes.Count - 1];
                workDurations.Add(workDuration);
                isClockedIn = false;

                ClockOutList.Items.Add(clockOutTime.ToString("yyyy-MM-dd HH:mm:ss"));
                lstWorkDuration.Items.Add(workDuration.TotalHours.ToString("F2") + " hours");
                UpdateTotalHours();
                MessageBox.Show("Clocked out successfully.", "Clock Out Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You are not clocked in. Please clock in before clocking out.", "Clock Out Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateTotalHours()
        {
            double totalHours = 0;
            foreach (var duration in workDurations)
            {
                totalHours += duration.TotalHours;
            }
            lblTotalHours.Text = "Total Hours Worked: " + totalHours.ToString("F2") + " hours";
        }
        string connectionString = "D:\\Lasalle College";

    }
}
        