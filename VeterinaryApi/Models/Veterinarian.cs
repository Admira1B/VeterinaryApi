namespace VeterinaryApi.Models
{
    public class Veterinarian
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}