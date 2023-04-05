using VeterinaryApi.Dtos.PetDto;

namespace VeterinaryApi.Services.PetService
{
    public interface IPetService
    {
        Task<List<GetPetDto>> GetPets();
        Task<GetPetDto> GetPet(int id);
        Task<GetPetDto> AddNewPet(AddPetDto petDto);
        Task DeletePet(int id);
        Task UpdatePet(int id, UpdatePetDto petDto);
    }
}