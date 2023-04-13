using VeterinaryApi.Models;

namespace VeterinaryApi.Dtos.PetDto
{
    public class UpdatePetDto
    {
        public string Name { get; set; } = string.Empty;
        public int TypeId { get; set; }
        public int Age { get; set; }
        public Sex SexOfAnimal { get; set; }
    }
}
