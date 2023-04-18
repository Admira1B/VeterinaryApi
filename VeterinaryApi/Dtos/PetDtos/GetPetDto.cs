using VeterinaryApi.Models;

namespace VeterinaryApi.Dtos.PetDto
{
    public class GetPetDto
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public int Age { get; set; }
        public Sex SexOfAnimal { get; set; }
        public PetOwner Owner { get; set; }
    }
}
