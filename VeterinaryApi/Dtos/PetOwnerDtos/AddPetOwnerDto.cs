using VeterinaryApi.Models;

namespace VeterinaryApi.Dtos.PetOwnerDtos
{
    public class AddPetOwnerDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public List<Pet> Pets { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
