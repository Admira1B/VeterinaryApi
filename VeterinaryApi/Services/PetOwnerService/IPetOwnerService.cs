using VeterinaryApi.Dtos.PetOwnerDtos;

namespace VeterinaryApi.Services.PetOwnerService
{
    public interface IPetOwnerService
    {
        Task<List<GetPetOwnerDto>> GetOwners();
        Task<GetPetOwnerDto> GetOwner(int id);

        Task<GetPetOwnerDto> AddNewPetOwner(AddPetOwnerDto petOwnerDto);
        Task DeleteOwner(int id);
        Task UpdateOwner(int id, UpdatePetOwnerDto ownerDto);
    }
}