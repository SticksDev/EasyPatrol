using AutoUpdaterDotNET;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace EasyPatrol
{
    public partial class welcomeScreen : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private bool isDefaultProfile;
        private Profile profile;
        private string tsclient = "";

        public welcomeScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Info("EasyPatrol GUI Initializing");
        }

        // On form ready 
        private void Form1_Shown(Object sender, EventArgs e)
        {
            log.Info("EasyPatrol GUI Ready. Invoking patrold");
            // Create an instance of patrold
            patrold patrold = new patrold();

            // Sub to ready event
            patrold.patroldReady += patrold_patroldReady;

            // Init patrold
            patrold.initialize();

            // Check for updates
            AutoUpdater.Mandatory = true;
            AutoUpdater.UpdateMode = Mode.Forced;

            // Notify of all actions 
            AutoUpdater.ReportErrors = true;

            AutoUpdater.Start("https://vps1.sticks.ovh/versioninfo.xml");
        }

        private void startProcessChecker()
        {
            // Start a loop that looks for these processes:
            // - fivem.exe
            // - TeamSpeak 3.exe

            // Start loop
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

            // Every 30 seconds
            timer.Interval = 1000;

            timer.Tick += (sender, e) =>
                {
                    // Check if process is running
                    if (Process.GetProcessesByName("fivem").Length > 0)
                    {
                        // Process is running
                        fiveMState.Text = "FiveM Status: Running";
                        fiveMState.ForeColor = Color.Green;
                    }
                    else
                    {
                        // Process is not running
                        fiveMState.Text = "FiveM Status: Not running";
                        fiveMState.ForeColor = Color.Red;
                    }

                    if (Process.GetProcessesByName(tsclient).Length > 0)
                    {
                        // Process is running
                        tsState.Text = "TeamSpeak 3 Status: Running";
                        tsState.ForeColor = Color.Green;
                    }
                    else
                    {

                        tsState.Text = "TeamSpeak 3 Status: Not running";
                        tsState.ForeColor = Color.Red;
                    }
                };

            timer.Start();
        }

        private void patrold_patroldReady(object sender, patrold.patroldReadyEventArgs e)
        {
            // Write the event args 
            log.Info("patrold 1.0 ready");

            // Check if the current loaded profile has the default profile
            // Bool is isDefaultProfile, use bool function to find if it is the default profile

            // Load profile into the Profile const
            profile = (Profile)e.profile;

            // tsclient is the process we are looking for
            // has 32 bit and 64 bit versions - so get the system architecture
            // Then the respective name of the teamspeak client

            if (Environment.Is64BitOperatingSystem)
            {
                tsclient = "ts3client_win64";
            }
            else
            {
                tsclient = "ts3client_win32";
            }



            if (profile.UnitNumber == "notset" & profile.Name == "notset")
            {
                // Profile is not set
                isDefaultProfile = true;
            }
            else
            {
                // Profile is set
                isDefaultProfile = false;
            }

            if (e.isNewProfile | isDefaultProfile)
            {
                // Show messageBox saying that its a new profile and needs to be configured
                // MsgBox should be type warning
                MessageBox.Show("New Profile Detected or Default Profile Detected. Please ensure you add your details in before starting patrol.", "New Profile Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Set the profileState to needs editing
                // Text: Profile Status: (COLOR RED) Needs Editing
                profileState.Text = "Profile Status: Needs Editing";
                profileState.ForeColor = Color.Red;

                isDefaultProfile = true;
            }
            else
            {
                // Set the profileState to ready
                // Text: Profile Status: (COLOR GREEN) Ready
                profileState.Text = "Profile Status: Ready";
                profileState.ForeColor = Color.Green;
            }

            // Check if fiveM.exe and TeamSpeak 3 process is running

            Process[] fiveMProcesses = Process.GetProcessesByName("fivem");
            Process[] ts3Processes = Process.GetProcessesByName(tsclient);

            // Check if fiveMProcesses is running
            if (fiveMProcesses.Length > 0)
            {
                // Set the fiveMStatus to running
                // Text: FiveM Status: (COLOR GREEN) Running
                fiveMState.Text = "FiveM Status: Running";
                fiveMState.ForeColor = Color.Green;
            }
            else
            {
                // Set the fiveMStatus to not running
                // Text: FiveM Status: (COLOR RED) Not Running
                fiveMState.Text = "FiveM Status: Not Running";
                fiveMState.ForeColor = Color.Red;
            }

            // Check if ts3Processes is running
            if (ts3Processes.Length > 0)
            {
                // Set the ts3Status to running
                // Text: TeamSpeak 3 Status: (COLOR GREEN) Running
                tsState.Text = "TeamSpeak 3 Status: Running";
                tsState.ForeColor = Color.Green;
            }
            else
            {
                // Set the ts3Status to not running
                // Text: TeamSpeak 3 Status: (COLOR RED) Not Running
                tsState.Text = "TeamSpeak 3 Status: Not Running";
                tsState.ForeColor = Color.Red;
            }

            // Start the process checker
            startProcessChecker();

        }

        private void startPatrolBttn_Click(object sender, EventArgs e)
        {
            // Check if there profile has been marked as default
            // If not, show messagebox saying that the profile needs to be configured

            if (isDefaultProfile)
            {
                MessageBox.Show("Please ensure you have configured your profile before starting patrol.", "Profile Not Configured", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if fiveM.exe and TeamSpeak 3 process is running

            Process[] fiveMProcesses = Process.GetProcessesByName("fivem");
            Process[] ts3Processes = Process.GetProcessesByName(tsclient);

            if (ts3Processes.Length == 0 | fiveMProcesses.Length == 0)
            {
                // Show messagebox saying that the process is not running
                // Ask if they want to contiune anyway
                // MsgBox should be type warning
                DialogResult result = MessageBox.Show("TeamSpeak 3 and/or FiveM is not running. Would you like to start patrol anyways?", "TeamSpeak 3 and/or FiveM Not Running", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Check if the user selected no
                // If not, contiune.

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            // Open patrol form
            patrolWindow patrolForm = new patrolWindow();

            this.Hide();

            patrolForm.Closed += (s, args) => Application.Exit();
            patrolForm.Show();
        }

        private void editProfileBttn_Click(object sender, EventArgs e)
        {
            // Load the profileForm
            profileForm profileForm = new profileForm();

            // Show the profileForm
            profileForm.Show();

            // Disable the editProfile button and start patrol button
            editProfileBttn.Enabled = false;
            startPatrolBttn.Enabled = false;

            // On profile edit
            profileForm.profileEdited += profileForm_profileEdited;

            // On form close
            profileForm.FormClosed += profileForm_FormClosed;
        }

        private void profileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Re enable buttons
            editProfileBttn.Enabled = true;
            startPatrolBttn.Enabled = true;
        }

        private void profileForm_profileEdited(object sender, profileForm.profileEditedEventArgs e)
        {
            // Set the profile to the new profile
            profile = (Profile)e.newProfile;

            // Re enable buttons
            editProfileBttn.Enabled = true;
            startPatrolBttn.Enabled = true;

            // Check the profile to ensure it has the correct details
            if (profile.UnitNumber != "notset" & profile.Name != "notset")
            {
                // Profile is set
                isDefaultProfile = false;

                // Set profile state to ready
                // Text: Profile Status: (COLOR GREEN) Ready
                profileState.Text = "Profile Status: Ready";
                profileState.ForeColor = Color.Green;

                // MsgBox Showing that the profile has been configured
                // INFO
                MessageBox.Show("Your profile is now ready to use.", "Profile Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // MsgBox Showing that the profile has NOT been configured
                // Error
                MessageBox.Show("You are still missing the required values (Name, Unit No). Please edit and add those.", "Profile Vaildation Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
