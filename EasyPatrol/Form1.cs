﻿using Newtonsoft.Json;
using System;
using System.Timers;
using System.Windows.Forms;

namespace EasyPatrol
{
    public partial class patrolWindow : Form
    {
        public patrolWindow()
        {
            InitializeComponent();
        }
        
        private DateTime startDate;
        private DateTime endDate;
        private Profile profile;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // Create a stopwatch in the HH:MM:SS format
        private System.Timers.Timer patrolTimer = new System.Timers.Timer();

        // Create the tick event for patrolTimer
        private void patrolTimer_Tick(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
              {
                  TimeSpan timeSpan = DateTime.Now - startDate;
                  string time = timeSpan.ToString(@"hh\:mm\:ss");
                  currPatrolTime.Text = "Current Patrol Time: " + time;
              });
        }


        private void upperClockDisplay()
        {
            // This function is used to display the time in the upper right corner of the screen.
            // It is called every second.

            // Start the loop using a timer.
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnClockUpdate);

            // Set the Interval to 1 second.
            aTimer.Interval = 1000;

            // Start the timer.
            aTimer.Start();
        }

       private void loadProfileInfo()
        {
            // Load the profile from the profile.json in %appdata%
            profile = JsonConvert.DeserializeObject<Profile>(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\profile.json"));

            // Set the labels for the profile.
            currentIdent.Text = "Current Identifier: " + profile.Name + " " + profile.UnitNumber;
            currentDept.Text = "Department: " + profile.MainDept;
        }

        private void OnClockUpdate(object sender, ElapsedEventArgs e)
        {
            // Update labels
            this.Invoke((MethodInvoker)delegate
            {
                // Update the time
                DateTime time = DateTime.Now;
                this.upperClock.Text = time.ToString("F");
            });
        }

        private void patrolWindow_Shown(object sender, EventArgs e)
        {
            // Start the clock
            upperClockDisplay();

            // Fill the profile info
            loadProfileInfo();
        }

        private void enableRideAlongSettings_CheckedChanged(object sender, EventArgs e)
        { 
            if(enableRideAlongSettings.Checked)
            {
                // Enable the ride along settings
                rideAlongUnitIdentText.Visible = true;
                rideAlongUnitText.Visible = true;
                unitRideAlongIdent.Visible = true;
                unitRideAlongWebID.Visible = true;
            }
            else
            {
                // Disable the ride along settings
                rideAlongUnitIdentText.Visible = false;
                rideAlongUnitText.Visible = false;
                unitRideAlongIdent.Visible = false;
                unitRideAlongWebID.Visible = false;
            }
        }
        
        private void startAndPause_Click(object sender, EventArgs e)
        {
            if(serverChooserBox.SelectedItem == null)
            {
                // Show an error message saying that a server must be selected.
                MessageBox.Show("Please select a server to patrol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startDate.ToString() != null & endDate.ToString() != null)
            {
                // Warn them that this will overwrite the current saved data.
                DialogResult result = MessageBox.Show("This will overwrite the current saved patrol data. Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Clear the start and end dates
                    startDate = DateTime.MinValue;
                    endDate = DateTime.MinValue;
                }
                else
                {
                    // Do nothing.
                    return;
                }
            }

            // Set the start date
            startDate = DateTime.Now;

            // Update the start date label
            startDateLabel.Text = "Patrol Start Time/Date: " + startDate.ToString("g");

            patrolTimer.Elapsed += patrolTimer_Tick;

            currentStatus.Text = "Current Status: Patrol Started";
            currentStatus.ForeColor = System.Drawing.Color.Green;

            startAndPause.Enabled = false;

            // Start the patrol
            patrolTimer.Start();
        }

        private void stopPatrol_Click(object sender, EventArgs e)
        {
            // Warn that this will stop the patrol.
            DialogResult result = MessageBox.Show("Are you sure you want to stop the patrol?\nYOU CANNOT PAUSE, THIS WILL STOP THE TIMER!", "Stop Patrol", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Stop the patrol
                patrolTimer.Stop();

                // Update the end date
                endDate = DateTime.Now;

                // Update the end date label
                endDateLabel.Text = "Patrol End Time/Date: " + endDate.ToString("g");

                // Update the current status
                currentStatus.Text = "Current Status: Patrol Finished";
                currentStatus.ForeColor = System.Drawing.Color.Yellow;

                startAndPause.Enabled = true;
            }
        }

        private void serverChooserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the server label to the new index
            serverLabel.Text = "Current Selected Server: " + serverChooserBox.SelectedItem.ToString();
        }
    }
}
