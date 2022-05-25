using Newtonsoft.Json;
using System;

namespace EasyPatrol
{
    class patrold
    {
        // Load the default log4net logger into a private called log
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public object profile;

        // Create an emiter for the patrolEvent and patroldReady

        // Create patroldReadyEventArgs
        public class patroldReadyEventArgs : EventArgs
        {
            public bool isReady { get; set; }
            public bool isNewProfile { get; set; }
        }
        
        public event EventHandler<patroldReadyEventArgs> patroldReady;
        public bool isNewProfile;
        
        public void initialize()
        {
            // Log that we are starting up
            log.Info("EasyPatrold starting up at " + DateTime.Now.ToString());
            log.Info("Searching for profile...");

            // Check if the profile exists (%appdata%/EasyPatrol/profile.json)
            if (System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\profile.json"))
            {
                // If it does, load it
                log.Info("Profile found, loading...");
                profile = JsonConvert.DeserializeObject<Profile>(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\profile.json"));
                log.Info("Profile loaded");
                isNewProfile = false;
            }
            else
            {
                // If it doesn't, create a new one
                log.Info("Profile not found, creating new...");

                // Create the folder in %appdata%/EasyPatrol/ if it does not already exist
                if (!System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\"))
                {
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\");
                }

                // Create a new file
                System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\profile.json").Close();

                // Write the default profile to the file
                System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\profile.json", JsonConvert.SerializeObject(new Profile("LSPD", "0", "0", "0", "EST")));

                log.Info("Profile created successfully.");

                // Load the new profile
                profile = JsonConvert.DeserializeObject<Profile>(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\profile.json"));
                isNewProfile = true;
            }

            // Emit the ready event with isReady = true.
            patroldReady?.Invoke(this, new patroldReadyEventArgs() { isReady = true, isNewProfile = isNewProfile });
        }
    }
}
