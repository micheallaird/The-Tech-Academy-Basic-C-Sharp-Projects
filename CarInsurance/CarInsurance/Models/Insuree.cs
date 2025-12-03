namespace CarInsurance.Models
{
    public class Insuree
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int DUI { get; set; } = 0;
        public int SpeedingTickets { get; set; } = 0;
        public string CoverageType { get; set; } = string.Empty;
        public decimal Quote { get; set; } = 0.0m;
    }
}
