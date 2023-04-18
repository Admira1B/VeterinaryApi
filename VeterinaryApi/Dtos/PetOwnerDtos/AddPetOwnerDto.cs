using VeterinaryApi.Models;

namespace VeterinaryApi.Dtos.PetOwnerDtos
{
    public class AddPetOwnerDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; }
    }
}
