namespace TimeEntrySystem.API.Dtos
{
    public class EmployeeForCreationDto
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Position { get; set; }

        public string Role { get; set; }

        public double HourlyPay {get; set; }

        public int PIN { get; set; }    


    }
}