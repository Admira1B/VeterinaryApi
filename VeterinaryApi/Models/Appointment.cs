namespace VeterinaryApi.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public PetOwner Owner { get; set; } // Запись на прием осуществляется через владельца.
        public int OwnerId { get; set; }
        public Veterinarian Veterinarian { get; set; }
        public int VeterinarianId { get; set; }
        public DateTimeOffset EditDate { get; set; }
    }
}