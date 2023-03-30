using VeterinaryApi.Models;

namespace VeterinaryApi.Dtos.PetDto
{
    public class UpdatePetDto
    {
        public string Name { get; set; } = string.Empty;
        public TypeOfAnimal Type { get; set; }
        public int TypeId { get; set; }
        public int Age { get; set; }
        public Sex SexOfAnimal { get; set; }
        public List<PetOwner> Owners { get; set; }
        public List<Illness> Illnesses { get; set; }
        public List<Vaccine> Vaccines { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
