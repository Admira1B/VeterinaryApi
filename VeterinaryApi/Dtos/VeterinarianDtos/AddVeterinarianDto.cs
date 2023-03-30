using VeterinaryApi.Models;

namespace VeterinaryApi.Dtos.VeterinarianDtos
{
    public class AddVeterinarianDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Appointment> Appointments { get; set; }
    }
}
