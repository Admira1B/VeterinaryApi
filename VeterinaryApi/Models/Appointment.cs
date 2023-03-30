namespace VeterinaryApi.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public Pet Pet { get; set; }
        public int PetId { get; set; }
        public Veterinarian Veterinarian { get; set; }
        public int VeterinarianId { get; set; }
        public DateTimeOffset EditDate { get; set; }
    }
}