using VeterinaryApi.Models;

namespace VeterinaryApi.Dtos.PetDto
{
    public class GetPetDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public TypeOfAnimal Type { get; set; }
        public int TypeId { get; set; }
        public int Age { get; set; }
        public Sex SexOfAnimal { get; set; }
        public PetOwner Owner { get; set; }
    }
}
