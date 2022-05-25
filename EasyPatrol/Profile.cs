namespace EasyPatrol
{
    internal class Profile
    {
        // Struct for DOJProfile:
        // MainDept = The main department of the user
        // UnitNumber = The unit number of the user
        // WebID = The web id of the user
        // Name = The name of the user
        // TimeZone = The timezone of the user

        public string MainDept { get; set; }
        public string UnitNumber { get; set; }
        public string WebID { get; set; }
        public string Name { get; set; }
        public string TimeZone { get; set; }

        public Profile(string mainDept, string unitNumber, string webID, string name, string timeZone)
        {
            MainDept = mainDept;
            UnitNumber = unitNumber;
            WebID = webID;
            Name = name;
            TimeZone = timeZone;
        }
    }
}