using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace EasyPatrol
{
    public partial class profileForm : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Profile profile;

        // Create profileEdited event with args
        public event EventHandler<profileEditedEventArgs> profileEdited;

        public class profileEditedEventArgs : EventArgs
        {
            public object newProfile { get; set; }
        }

        public profileForm()
        {
            InitializeComponent();
        }

        public void editCurrentProfile()
        {
            // First, delete the old profile
            System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\profile.json");

            // Create a new profile using the data from the form
            Profile newProfile = new Profile(departmentPicker.Text, DOJUnitEntry.Text, DOJWebIDEntry.Text, DOJNameEntry.Text, TimezoneEntry.Text);

            // Then, write the new profile to the file
            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\profile.json", JsonConvert.SerializeObject(newProfile));

            // Finally, raise the profileEdited event
            profileEdited?.Invoke(this, new profileEditedEventArgs { newProfile = newProfile });

            // Close the form
            this.Close();
        }

        private void profileForm_Shown(object sender, EventArgs e)
        {
            log.Info("Profile form shown.");

            // Load profile from file
            profile = JsonConvert.DeserializeObject<Profile>(System.IO.File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\EasyPatrol\\profile.json"));

            // Set form values
            departmentPicker.SelectedIndex = departmentPicker.FindStringExact(profile.MainDept);
            DOJNameEntry.Text = profile.Name;
            DOJUnitEntry.Text = profile.UnitNumber;
            TimezoneEntry.Text = profile.TimeZone;
            DOJWebIDEntry.Text = profile.WebID;
        }

        private void saveAndExit_Click(object sender, EventArgs e)
        {
            // Make sure all fields are filled out
            if (departmentPicker.Text == "" ||
                DOJNameEntry.Text == "" ||
                DOJUnitEntry.Text == "" ||
                TimezoneEntry.Text == "" ||
                DOJWebIDEntry.Text == "")
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save profile
            editCurrentProfile();
        }
    }
}
