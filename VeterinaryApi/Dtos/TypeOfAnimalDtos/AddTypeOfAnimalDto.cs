using VeterinaryApi.Models;

namespace VeterinaryApi.Dtos.TypeOfAnimalDtos
{
    public class AddTypeOfAnimalDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
