namespace TimeEntrySystem.API.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Position { get; set; }

        public string Status { get; set; }

        public string HoursWorked { get; set; }

        public string Role { get; set; }

        public double HourlyPay { get; set; }
        
    }
}