using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPatrol
{
    public partial class Form1 : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            log.Info("Form1_Load");
        }

        // On form ready 
        private void Form1_Shown(Object sender, EventArgs e)
        {
            log.Info("Form1_Shown");
            // Create an instance of patrold
            patrold patrold = new patrold();

            // Sub to ready event
            patrold.patroldReady += patrold_patroldReady;

            // Init patrold
            patrold.initialize();

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

            // tsclient is the process we are looking for
            // has 32 bit and 64 bit versions
            // Check OS bit

            string tsclient = "";
            
            if(Environment.Is64BitOperatingSystem)
            {
                tsclient = "ts3client_win64";
            }
            else
            {
                tsclient = "ts3client_win32";
            }


            timer.Tick += (sender, e) =>
                {
                    log.Debug(tsclient);
                    // Check if process is running
                    if (Process.GetProcessesByName("fivem").Length > 0)
                    { 
                        // Process is running
                        fiveMState.Text = "FiveM Status: Running";
                        fiveMState.ForeColor = Color.Green;


                        log.Debug("FiveM is running");
                    }
                    else
                    {
                        // Process is not running
                        fiveMState.Text = "FiveM Status: Not running";
                        fiveMState.ForeColor = Color.Red;

                        log.Debug("FiveM is not running");
                    }

                    if (Process.GetProcessesByName(tsclient).Length > 0)
                    {
                        // Process is running
                        tsState.Text = "TeamSpeak 3 Status: Running";
                        tsState.ForeColor = Color.Green;

                        log.Debug("TeamSpeak 3.exe is running");
                    }
                    else
                    {

                        tsState.Text = "TeamSpeak 3 Status: Not running";
                        tsState.ForeColor = Color.Red;

                        // Process is not running
                        log.Debug("TeamSpeak 3.exe is not running");
                    }
                };

            timer.Start();
        }

        private void patrold_patroldReady(object sender, patrold.patroldReadyEventArgs e)
        {
            // Write the event args 
            log.Info("PatrolD is now ready. Current Client Info:");
            
            if(e.isNewProfile) {
                // Show messageBox saying that its a new profile and needs to be configured
                // MsgBox should be type warning
                MessageBox.Show("New Profile Detected. Please ensure you add your details in before starting patrol.", "New Profile Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Set the profileState to needs editing
                // Text: Profile Status: (COLOR RED) Needs Editing
                profileState.Text = "Profile Status: Needs Editing";
                profileState.ForeColor = Color.Red;
            } else {
                // Set the profileState to ready
                // Text: Profile Status: (COLOR GREEN) Ready
                profileState.Text = "Profile Status: Ready";
                profileState.ForeColor = Color.Green;
            }

            // Check if fiveM.exe and TeamSpeak 3 process is running

            Process[] fiveMProcesses = Process.GetProcessesByName("fivem");
            Process[] ts3Processes = Process.GetProcessesByName("TeamSpeak 3");

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
    }
}
