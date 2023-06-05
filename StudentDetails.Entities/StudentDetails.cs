namespace StudentDetails.Entities
{
    public class StudentDetailsList
    {
        public StudentDetailsList(string firstName, string lastName, string gender, string rollNumber, DateTime dateOfBirth, string address, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.rollNumber = rollNumber;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string rollNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        
        public string address { get; set; }
        public string phoneNumber { get; set; }
    }
}